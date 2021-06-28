#!/bin/sh
GUID="$1"
EXPORT_DIR="./TestResults/${GUID}"

reportgenerator "-reports:${EXPORT_DIR}/coverage.cobertura.xml" "-targetdir:${EXPORT_DIR}/coveragereport" -reporttypes:Html