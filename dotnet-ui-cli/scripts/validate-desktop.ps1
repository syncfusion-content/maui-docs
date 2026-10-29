param(
    [ValidateSet('wpf','winforms','winui')][string]$Platform = 'wpf',
    [ValidateSet('C#','VB')][string]$Language = 'C#',
    [string]$TargetFramework = 'net10.0',
    [string]$Cli = "$PSScriptRoot/../src/Syncfusion.DotNet.CLI/bin/Release/net10.0/sf.dll",
    [string]$Output = "$PSScriptRoot/../artifacts/desktop-validation",
    [switch]$Launch,
    [ValidateRange(1,60)][int]$LaunchTimeoutSeconds = 30
)
$ErrorActionPreference = 'Stop'
try {
if (-not $IsWindows) { throw 'This validation requires Windows desktop build tools.' }
function Invoke-Checked([string]$Tool, [string[]]$Arguments) {
    $outputLines = & $Tool @Arguments 2>&1
    $code = $LASTEXITCODE
    $outputLines | ForEach-Object { Write-Host $_ }
    if ($code -ne 0) { throw "$Tool failed with exit code ${code}: $($outputLines | Select-Object -Last 20 | Out-String)" }
}
$Cli = (Resolve-Path $Cli).Path
New-Item -ItemType Directory -Force $Output | Out-Null
$Output = (Resolve-Path $Output).Path
$themes = switch ($Platform) {
    'wpf' { @('Windows11Light','Windows11Dark','Material3Light','Material3Dark','Office2019Colorful') }
    'winforms' { @('Office2019Colorful') }
    'winui' { @('Native') }
}
$legacy = $TargetFramework -in @('net462','net47','net48')
$msbuild = $null
if ($legacy) {
    $vswhere = "${env:ProgramFiles(x86)}/Microsoft Visual Studio/Installer/vswhere.exe"
    $msbuild = & $vswhere -latest -products '*' -requires Microsoft.Component.MSBuild -find 'MSBuild/**/Bin/MSBuild.exe' | Select-Object -First 1
    if (-not $msbuild) { throw 'Visual Studio desktop MSBuild is required.' }
}
$providerName = switch ($Platform) {
    'wpf' { 'WPF' }
    'winforms' { 'WinForms' }
    'winui' { 'WinUI' }
}
$catalogPath = Join-Path $PSScriptRoot "../src/Syncfusion.DotNet.CLI.$providerName/${providerName}ControlCatalog.cs"
$catalog = @([regex]::Matches((Get-Content $catalogPath -Raw), 'new\("([^" ]+)"') | ForEach-Object { $_.Groups[1].Value })
if ($catalog.Count -eq 0) { throw "No controls found in $catalogPath" }
$chart = if ($Platform -eq 'winui') { 'cartesian-chart' } else { 'chart' }
$combinations = [System.Collections.Generic.List[object]]::new()
$combinations.Add(@())
foreach ($control in $catalog) { $combinations.Add(@($control)) }
$combinations.Add(@($chart,'datagrid'))
$combinations.Add($catalog)
$number = 0
foreach ($theme in $themes) {
    foreach ($controls in $combinations) {
        $number++
        $name = "Desktop${Platform}$($Language.Replace('#','s'))$($TargetFramework.Replace('.',''))Case$number"
        $folder = Join-Path $Output $name
        if (Test-Path $folder) { throw "Validation destination already exists: $folder. Choose a fresh -Output." }
        $args = @($Cli,'new',$Platform,'--name',$name,'--path',$Output,'--language',$Language,'--target-framework',$TargetFramework,'--theme',$theme,'--post-action','build','--no-interactive','--no-color')
        foreach ($control in $controls) { $args += @('--control',$control) }
        Invoke-Checked 'dotnet' $args
        $extension = if ($Language -eq 'VB') { 'vbproj' } else { 'csproj' }
        $project = Join-Path $folder "$name.$extension"
        # Treat warnings as failures as well as validating the CLI's own build path.
        if ($legacy) { Invoke-Checked $msbuild @($project,'/t:Rebuild','/p:TreatWarningsAsErrors=true') }
        else { Invoke-Checked 'dotnet' @('build',$project,'--no-restore','-warnaserror') }
        if ($Launch) {
            $exe = Get-ChildItem (Join-Path $folder 'bin') -Filter "$name.exe" -Recurse | Select-Object -First 1
            if (-not $exe) { throw "No application executable found: $name" }
            $process = Start-Process $exe.FullName -WorkingDirectory $exe.DirectoryName -PassThru
            try {
                $visible = $false
                for ($attempt = 0; $attempt -lt ($LaunchTimeoutSeconds * 10); $attempt++) {
                    Start-Sleep -Milliseconds 100
                    $process.Refresh()
                    if ($process.HasExited) { throw "$name exited before displaying a window (exit $($process.ExitCode))." }
                    if ($process.MainWindowHandle -ne 0 -and $process.MainWindowTitle -eq $name) { $visible = $true; break }
                }
                if (-not $visible) { throw "$name did not display a native window within $LaunchTimeoutSeconds seconds." }
                Start-Sleep -Seconds 2
                $process.Refresh()
                if ($process.HasExited) { throw "$name exited during its runtime smoke check (exit $($process.ExitCode))." }
                Write-Host "Runtime smoke passed: $name displayed a native window."
            }
            finally { if (-not $process.HasExited) { $process.Kill($true); $process.WaitForExit() } }
        }
        Write-Host "Validated $Platform $Language $TargetFramework $theme controls=$($controls -join ',')"
    }
}

}
catch {
    # Make the actual failure available through GitHub check annotations too.
    $message = $_.Exception.Message.Replace('%','%25').Replace("`r",'%0D').Replace("`n",'%0A')
    Write-Host "::error::$message"
    throw
}
