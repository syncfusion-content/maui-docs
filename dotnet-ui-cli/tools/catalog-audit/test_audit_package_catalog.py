import unittest

from audit_package_catalog import audit_catalog, collect_search_results


class CatalogAuditTests(unittest.TestCase):
    def test_pagination_uses_offsets_and_stops_at_total_hits(self):
        pages = {
            0: {
                "totalHits": 3,
                "data": [
                    {"id": "Syncfusion.Maui.Core", "owners": "SyncfusionInc", "listed": True},
                    {"id": "Other.Package", "owners": "Other", "listed": True},
                ],
            },
            2: {
                "totalHits": 3,
                "data": [
                    {"id": "Syncfusion.Maui.Toolkit", "owners": "SyncfusionInc", "listed": True},
                ],
            },
        }
        offsets = []

        def fetch_page(skip, take):
            offsets.append((skip, take))
            return pages[skip]

        results, page_count = collect_search_results(fetch_page, page_size=2)

        self.assertEqual([(0, 2), (2, 2)], offsets)
        self.assertEqual(2, page_count)
        self.assertEqual(3, len(results))

    def test_catalog_comparison_reports_without_mutating_catalog(self):
        catalog = {
            "packages": [
                {
                    "packageId": "Syncfusion.Maui.Core",
                    "category": "Infrastructure",
                    "productFamily": "shared-infrastructure",
                    "classification": "dependency-only",
                    "status": "stable",
                    "registrationRequirement": "syncfusion-core",
                },
                {
                    "packageId": "Syncfusion.Maui.Unresolved",
                    "category": "Unresolved",
                    "productFamily": "unresolved",
                    "classification": "unresolved",
                    "status": "stable",
                    "registrationRequirement": "unverified",
                },
            ],
        }
        before = repr(catalog)
        results = [
            {"id": "Syncfusion.Maui.Core", "owners": "SyncfusionInc", "listed": True},
            {"id": "Syncfusion.Maui.NewPackage", "owners": "SyncfusionInc", "listed": True},
            {"id": "Syncfusion.Maui.OldPackage", "owners": "SyncfusionInc", "listed": False},
            {"id": "Syncfusion.Maui.Impostor", "owners": "SomebodyElse", "listed": True},
            {"id": "Other.Package", "owners": "SyncfusionInc", "listed": True},
        ]

        report = audit_catalog(catalog, results, page_count=1)

        self.assertEqual(["Syncfusion.Maui.Unresolved"], report["missingFromOfficialListedSearch"])
        self.assertEqual(["Syncfusion.Maui.NewPackage"], report["officialListedNotInCatalog"])
        self.assertEqual(["Syncfusion.Maui.OldPackage"], report["officialUnlistedResults"])
        self.assertEqual(["Syncfusion.Maui.Unresolved"], report["metadataReview"])
        self.assertIn("never writes", report["notice"])
        self.assertEqual(before, repr(catalog))


if __name__ == "__main__":
    unittest.main()
