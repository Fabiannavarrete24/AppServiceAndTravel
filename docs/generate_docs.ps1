# ==========================================
# generate_docs.ps1
# ==========================================

$ErrorActionPreference = 'Continue'

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Iniciando generación de documentación..." -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan

$scriptRoot = Split-Path -Parent $MyInvocation.MyCommand.Definition
$repoRoot = Resolve-Path "$scriptRoot\.." | Select-Object -ExpandProperty Path

$toolsDir = Join-Path $repoRoot "tools\plantuml"
$plantumlJar = Join-Path $toolsDir "plantuml.jar"

$diagramsDir = Join-Path $scriptRoot "diagrams"
$outputDir = Join-Path $scriptRoot "output"

New-Item -ItemType Directory -Force -Path $toolsDir | Out-Null
New-Item -ItemType Directory -Force -Path $diagramsDir | Out-Null
New-Item -ItemType Directory -Force -Path $outputDir | Out-Null

function Command-Exists {
    param([string]$Command)
    return $null -ne (Get-Command $Command -ErrorAction SilentlyContinue)
}

function Add-ToPath {
    param([string]$Folder)

    if (!(Test-Path $Folder)) {
        return
    }

    if ($env:Path -notlike "*$Folder*") {
        $env:Path += ";$Folder"
    }

    $userPath = [Environment]::GetEnvironmentVariable(
        "Path",
        [EnvironmentVariableTarget]::User
    )

    if ($userPath -notlike "*$Folder*") {
        [Environment]::SetEnvironmentVariable(
            "Path",
            "$userPath;$Folder",
            [EnvironmentVariableTarget]::User
        )
    }
}

function Find-Executable {
    param(
        [string]$Executable,
        [string[]]$CommonPaths
    )

    $cmd = Get-Command $Executable -ErrorAction SilentlyContinue

    if ($cmd) {
        return $cmd.Source
    }

    foreach ($path in $CommonPaths) {
        if (Test-Path $path) {
            return $path
        }
    }

    return $null
}

function Try-Install-With-Winget {
    param(
        [string]$PackageId,
        [string]$FriendlyName
    )

    if (!(Command-Exists winget)) {
        return $false
    }

    Write-Host "Instalando $FriendlyName..." -ForegroundColor Yellow

    try {
        winget install `
            --id $PackageId `
            -e `
            --accept-package-agreements `
            --accept-source-agreements `
            --include-unknown

        return $true
    }
    catch {
        return $false
    }
}

# ==========================================
# JAVA
# ==========================================

if (!(Command-Exists java)) {

    Write-Warning "Java no encontrado."

    Try-Install-With-Winget `
        "EclipseAdoptium.Temurin.21.JRE" `
        "Java"
}
else {
    Write-Host "Java detectado." -ForegroundColor Green
}

# ==========================================
# GRAPHVIZ
# ==========================================

$dotExe = Find-Executable `
    "dot.exe" `
    @(
        "C:\Program Files\Graphviz\bin\dot.exe",
        "C:\Program Files (x86)\Graphviz\bin\dot.exe"
    )

if (!$dotExe) {

    Write-Warning "Graphviz no encontrado."

    Try-Install-With-Winget `
        "Graphviz.Graphviz" `
        "Graphviz"

    $dotExe = Find-Executable `
        "dot.exe" `
        @(
            "C:\Program Files\Graphviz\bin\dot.exe",
            "C:\Program Files (x86)\Graphviz\bin\dot.exe"
        )
}

if ($dotExe) {

    Add-ToPath (Split-Path $dotExe)

    Write-Host "Graphviz detectado:" -ForegroundColor Green
    Write-Host $dotExe -ForegroundColor Green
}
else {
    Write-Warning "Graphviz no disponible."
}

# ==========================================
# PANDOC
# ==========================================

$hasPandoc = Command-Exists pandoc

if (!$hasPandoc) {

    Write-Warning "Pandoc no encontrado."

    Try-Install-With-Winget `
        "Pandoc.Pandoc" `
        "Pandoc"

    $hasPandoc = Command-Exists pandoc
}

if ($hasPandoc) {
    Write-Host "Pandoc detectado." -ForegroundColor Green
}

# ==========================================
# WKHTMLTOPDF
# ==========================================

$wkhtmlExe = Find-Executable `
    "wkhtmltopdf.exe" `
    @(
        "C:\Program Files\wkhtmltopdf\bin\wkhtmltopdf.exe",
        "C:\Program Files (x86)\wkhtmltopdf\bin\wkhtmltopdf.exe"
    )

if (!$wkhtmlExe) {

    Write-Warning "wkhtmltopdf no encontrado."

    Try-Install-With-Winget `
        "wkhtmltopdf.wkhtmltox" `
        "wkhtmltopdf"

    $wkhtmlExe = Find-Executable `
        "wkhtmltopdf.exe" `
        @(
            "C:\Program Files\wkhtmltopdf\bin\wkhtmltopdf.exe",
            "C:\Program Files (x86)\wkhtmltopdf\bin\wkhtmltopdf.exe"
        )
}

$hasWkhtml = $false

if ($wkhtmlExe) {

    Add-ToPath (Split-Path $wkhtmlExe)

    $hasWkhtml = $true

    Write-Host "wkhtmltopdf detectado." -ForegroundColor Green
}

# ==========================================
# PLANTUML
# ==========================================

if (!(Test-Path $plantumlJar)) {

    Write-Host "Descargando PlantUML..." -ForegroundColor Yellow

    Invoke-WebRequest `
        "https://github.com/plantuml/plantuml/releases/latest/download/plantuml.jar" `
        -OutFile $plantumlJar
}

# ==========================================
# ESTADO
# ==========================================

Write-Host ""
Write-Host "========== ESTADO ==========" -ForegroundColor Cyan
Write-Host "Java         :" (Command-Exists java)
Write-Host "PlantUML     :" (Test-Path $plantumlJar)
Write-Host "Graphviz     :" (Command-Exists dot)
Write-Host "Pandoc       :" (Command-Exists pandoc)
Write-Host "wkhtmltopdf  :" (Command-Exists wkhtmltopdf)
Write-Host "============================" -ForegroundColor Cyan
Write-Host ""

# ==========================================
# GENERAR DIAGRAMAS
# ==========================================

$diagrams = Get-ChildItem `
    -Path $diagramsDir `
    -Filter *.puml `
    -Recurse `
    -ErrorAction SilentlyContinue

foreach ($diagram in $diagrams) {

    Write-Host "Generando $($diagram.Name)..."

    java `
        -jar $plantumlJar `
        -tpng `
        -o $outputDir `
        $diagram.FullName

    java `
        -jar $plantumlJar `
        -tsvg `
        -o $outputDir `
        $diagram.FullName
}

# ==========================================
# GENERAR MARKDOWN
# ==========================================

$finalMd = Join-Path $outputDir "DOCUMENTACION_FINAL.md"
$finalPdf = Join-Path $outputDir "DOCUMENTACION_FINAL.pdf"

"" | Set-Content $finalMd -Encoding UTF8

$readme = Join-Path $repoRoot "README.md"
$informe = Join-Path $repoRoot "INFORME_TECNICO.md"

if (Test-Path $readme) {
    Get-Content $readme | Add-Content $finalMd
}

if (Test-Path $informe) {

    Add-Content $finalMd "`n`n---`n`n"

    Get-Content $informe | Add-Content $finalMd
}

$images = Get-ChildItem `
    -Path $outputDir `
    -Filter *.png

if ($images) {

    Add-Content $finalMd "`n`n# Diagramas`n"

    foreach ($img in $images) {

        Add-Content $finalMd "`n## $($img.BaseName)"
        Add-Content $finalMd "![]($($img.Name))"
    }
}

# ==========================================
# PDF
# ==========================================

if ($hasPandoc -and $hasWkhtml) {

    Write-Host "Generando PDF..." -ForegroundColor Cyan

    pandoc `
        $finalMd `
        -o `
        $finalPdf `
        --pdf-engine=wkhtmltopdf

    Write-Host "PDF generado:" -ForegroundColor Green
    Write-Host $finalPdf -ForegroundColor Green
}
else {
    Write-Warning "No fue posible generar el PDF."
}

Write-Host ""
Write-Host "Proceso finalizado." -ForegroundColor Cyan
Write-Host "Salida:" -ForegroundColor Cyan
Write-Host $outputDir -ForegroundColor Green
Write-Host "========================================"