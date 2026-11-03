#!/bin/sh
# Run the suite (minus the tracked known-failing tests) with coverlet and leave the
# report at a fixed path, because the collector writes into a random GUID directory.
# usage: coverage.sh <evidence-dir>
set -e
OUT="$1/cov"
rm -rf "$OUT"
dotnet test tests --nologo -c Release --no-build \
  --filter "FullyQualifiedName!~PdfViewerResourcesMatchCatalogNames&FullyQualifiedName!~ProjectEmbeddingExcludesMacMetadataAtEveryDepthAndKeepsTemplates&FullyQualifiedName!~InvalidExplicitTargetFramework_FailsBeforeProjectNameQuestion&FullyQualifiedName!~NameConflictAllowsReentryWithoutChangingExistingDestination" \
  --collect:"XPlat Code Coverage" --results-directory "$OUT" >/dev/null
SRC=$(ls -t "$OUT"/*/coverage.cobertura.xml | head -n 1)
cp "$SRC" "$OUT/coverage.cobertura.xml"
