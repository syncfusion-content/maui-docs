#!/usr/bin/env python3
"""Read-only advisory audit for the curated Syncfusion MAUI package catalog."""

from __future__ import annotations

import argparse
import json
from pathlib import Path
from typing import Any, Callable
from urllib.parse import urlencode
from urllib.request import Request, urlopen


REPOSITORY_ROOT = Path(__file__).resolve().parents[2]
DEFAULT_CATALOG = REPOSITORY_ROOT / "src/Platforms/Syncfusion.DotNet.Cli.Maui/Catalog/package-catalog.json"
DEFAULT_SOURCE = "https://api.nuget.org/v3/index.json"
PACKAGE_PREFIX = "Syncfusion.Maui."
OFFICIAL_OWNER = "syncfusioninc"


def fetch_json(url: str) -> dict[str, Any]:
    request = Request(url, headers={"User-Agent": "Syncfusion.DotNet.Cli catalog audit"})
    with urlopen(request, timeout=30) as response:
        return json.load(response)


def get_search_endpoint(source_url: str, get_json: Callable[[str], dict[str, Any]]) -> str:
    service_index = get_json(source_url)
    resources = service_index.get("resources", [])
    for resource in resources:
        resource_types = resource.get("@type", [])
        if isinstance(resource_types, str):
            resource_types = [resource_types]
        if any("SearchQueryService" in resource_type for resource_type in resource_types):
            return resource["@id"]
    raise ValueError(f"The NuGet service index has no SearchQueryService resource: {source_url}")


def collect_search_results(
    fetch_page: Callable[[int, int], dict[str, Any]],
    page_size: int = 100,
) -> tuple[list[dict[str, Any]], int]:
    if page_size <= 0 or page_size > 100:
        raise ValueError("The NuGet search page size must be between 1 and 100.")

    results: list[dict[str, Any]] = []
    skip = 0
    page_count = 0
    while True:
        page = fetch_page(skip, page_size)
        page_results = page.get("data")
        if not isinstance(page_results, list):
            raise ValueError(f"NuGet search page at offset {skip} has no data array.")
        page_count += 1
        results.extend(item for item in page_results if isinstance(item, dict))
        skip += len(page_results)
        total_hits = page.get("totalHits")
        if not page_results or len(page_results) < page_size:
            break
        if isinstance(total_hits, int) and skip >= total_hits:
            break
    return results, page_count


def audit_catalog(
    catalog: dict[str, Any],
    search_results: list[dict[str, Any]],
    page_count: int,
) -> dict[str, Any]:
    packages = catalog.get("packages")
    if not isinstance(packages, list):
        raise ValueError("The package catalog must contain a packages array.")

    catalog_by_id = {
        package["packageId"].casefold(): package
        for package in packages
        if isinstance(package, dict) and isinstance(package.get("packageId"), str)
    }
    matching_results = [
        result
        for result in search_results
        if isinstance(result.get("id"), str) and result["id"].startswith(PACKAGE_PREFIX)
    ]
    official_listed = {
        result["id"].casefold(): result
        for result in matching_results
        if result.get("listed") is not False
        and OFFICIAL_OWNER in str(result.get("owners", "")).casefold()
    }
    missing = sorted(
        package["packageId"]
        for package_id, package in catalog_by_id.items()
        if package_id not in official_listed
    )
    uncataloged = sorted(
        result["id"]
        for package_id, result in official_listed.items()
        if package_id not in catalog_by_id
    )
    unlisted = sorted(
        result["id"]
        for result in matching_results
        if result.get("listed") is False
        and OFFICIAL_OWNER in str(result.get("owners", "")).casefold()
    )
    metadata_review = sorted(
        package["packageId"]
        for package in packages
        if any(
            str(package.get(field, "")).casefold() in {"unresolved", "unverified"}
            for field in ("category", "productFamily", "classification", "status", "registrationRequirement")
        )
    )
    return {
        "source": "NuGet SearchQueryService advisory audit",
        "catalogPackageCount": len(catalog_by_id),
        "searchResultCount": len(search_results),
        "packagePrefixResultCount": len(matching_results),
        "pagesRead": page_count,
        "missingFromOfficialListedSearch": missing,
        "officialListedNotInCatalog": uncataloged,
        "officialUnlistedResults": unlisted,
        "metadataReview": metadata_review,
        "notice": "Search results are advisory only. Review repository product metadata, official documentation, package registration, and dependency metadata before changing the curated catalog. This tool never writes production catalog files.",
    }


def run_audit(
    catalog_path: Path,
    source_url: str = DEFAULT_SOURCE,
    page_size: int = 100,
    get_json: Callable[[str], dict[str, Any]] = fetch_json,
) -> dict[str, Any]:
    catalog = json.loads(catalog_path.read_text(encoding="utf-8"))
    search_endpoint = get_search_endpoint(source_url, get_json)

    def fetch_page(skip: int, take: int) -> dict[str, Any]:
        query = urlencode({
            "q": "Syncfusion.Maui",
            "prerelease": "true",
            "semVerLevel": "2.0.0",
            "take": take,
            "skip": skip,
        })
        separator = "&" if "?" in search_endpoint else "?"
        return get_json(f"{search_endpoint}{separator}{query}")

    results, page_count = collect_search_results(fetch_page, page_size)
    return audit_catalog(catalog, results, page_count)


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--catalog", type=Path, default=DEFAULT_CATALOG, help="Package catalog JSON path.")
    parser.add_argument("--source", default=DEFAULT_SOURCE, help="NuGet v3 service index URL.")
    parser.add_argument("--take", type=int, default=100, help="NuGet search page size (maximum supported by NuGet is 100).")
    arguments = parser.parse_args()

    report = run_audit(arguments.catalog, arguments.source, arguments.take)
    print(json.dumps(report, indent=2, sort_keys=True))
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
