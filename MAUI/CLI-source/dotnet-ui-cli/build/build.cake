#addin nuget:?package=Cake.FileHelpers&version=4.0.1
#tool "nuget:?package=JetBrains.dotCover.CommandLineTools&version=2020.1.4"
#tool nuget:?package=NUnit.ConsoleRunner&version=3.5.0
#tool "nuget:?package=ReportUnit&version=1.2.1"

using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release-Xml");
var referencepath = Argument("referencepath", "");
var outputpath = Argument("outputpath", "");
var STUDIO_VERSION = Argument<string>("studioversion","");
string assemblyfileversion = Argument<string>("assemblyfileversion","19.1.1.1	");
string Copyrights = "Copyright (c) 2001-"+DateTime.Now.Year+" Syncfusion. Inc,";
var nugetserverurl=Argument<string>("nugetserverurl","");
var nugetapikey=Argument<string>("nugetapikey","");
//String to hold the information of downloaded packages with its name and version. "package1:version;package2:version;....."
var downloadedPackageVersion = "";
var CodeanalysisViolationCount=0;
var fxCopViolationCount = 0;
var styleCopViolationCount=0;
//FileInfo slnFileInfo;
//DirectoryInfo sourcedirInfo;
string versionswitcherplatform="uwp";
var studio_version = Argument("studio_version", STUDIO_VERSION).Split('.'); 
var preReleaseNumber=Argument<string>("preReleaseNumber","");

List<string> nugetSource = new List<string>();

var nugetserverurls=nugetserverurl.Split(',');

foreach(var nugeturl in nugetserverurls)
{
    nugetSource.Add(nugeturl);
}

nugetserverurl =nugetserverurl.Split(',')[0];


//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////


// Define directories.

var buildDir = Directory("../Src/bin") + Directory(configuration);
var currentDirectory = MakeAbsolute(Directory("../"));
var referencedirpath = "../DependentAssemblies";
var currentDirectoryInfo=new DirectoryInfo(currentDirectory.FullPath);
var outdirectories = "";
var currentPath = MakeAbsolute(Directory("../"));

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////




Task("CopyrightandVersion")
  .IsDependentOn("Clean")
  .Does(() =>
{
  var assemblyfiles = GetFiles("../**/*AssemblyInfo.cs");
  foreach(var assemblyfile in assemblyfiles)
  {
	Information(assemblyfile.ToString());
	string  FileContents = System.IO.File.ReadAllText(assemblyfile.ToString());

	FileContents = FileContents.Replace(Regex.Match(FileContents, "[A|a]ssembly\\s*:\\s*AssemblyVersion\\(\"([\\d]{1,3}\\.[\\d]{1}.[\\d]{1,2})\"\\)").Groups[1].Value, STUDIO_VERSION);
	FileContents = FileContents.Replace(Regex.Match(FileContents, "[A|a]ssembly\\s*:\\s*AssemblyFileVersion\\(\"([\\d]{1,3}\\.[\\d]{1}.[\\d]{1,2})\"\\)").Groups[1].Value, STUDIO_VERSION);
	FileContents = FileContents.Replace(Regex.Match(FileContents, "[A|a]ssembly\\s*:\\s*AssemblyFileVersion\\(\"([\\d]{1,3}\\.[\\d]{1}.[\\d]{1,2})\"\\)").Groups[1].Value, STUDIO_VERSION);
	FileContents = FileContents.Replace(Regex.Match(FileContents, "assembly: AssemblyCopyright\\(\"(.*?)\"\\)").Groups[1].Value, Copyrights);
	
	System.IO.File.WriteAllText(assemblyfile.ToString(),FileContents);
  }
})
.OnError(exception =>
{
    FileWriteText("../cakelog.txt", "Error on Executing CopyrightandVersion:" + exception.ToString());
    throw new Exception("Cake process Failed on CopyrightandVersion Task");
});



Task("Clean")
    .Does(() =>
{
  var binDirectories=currentDirectoryInfo.GetDirectories("bin",SearchOption.AllDirectories);
  var objDirectories=currentDirectoryInfo.GetDirectories("obj",SearchOption.AllDirectories);

  foreach(var directory in binDirectories)
  CleanDirectories(directory.FullName);

  foreach(var directory in objDirectories)
  CleanDirectories(directory.FullName);																												
    
})
.OnError(exception =>
{
    FileWriteText("../cakelog.txt", "Error on Executing Clean:" + exception.ToString());
    throw new Exception("Cake process Failed on Clean Task");
});


Task("Restore-NuGet-Packages")
	.IsDependentOn("CopyrightandVersion")
    .Does(() =>
{
	var slnFiles = GetFiles("../**/*.sln");
	
	foreach(var slnFile in slnFiles){
		Information("slnFile {0}", slnFile);
		NuGetRestore(slnFile, new NuGetRestoreSettings{MSBuildVersion = NuGetMSBuildVersion.MSBuild15_9});
	}
})
.OnError(exception =>
{
    FileWriteText("../cakelog.txt", "Error on Executing Restore-NuGet-Packages:" + exception.ToString());
    throw new Exception("Cake process Failed on Restore-NuGet-Packages Task");
});

Task("build")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() =>{
	
	var slnFiles = GetFiles("../**/*.sln");	
	
	foreach(var slnFile in slnFiles){
		Information("slnFile {0}", slnFile);
		MSBuild(slnFile,  new MSBuildSettings()
        .SetConfiguration(configuration)
        .SetVerbosity(Verbosity.Verbose));
	}
	Information("Finished executing task: build");
});


Task("GetStyleCopReports")
	.Does(()=>{
    
    EnsureDirectoryExists("../../cireports/stylecop");
		DeleteFiles("../../cireports/stylecop"+"/*StyleCopAnalysis.xml");
		
		var styleCopAnalysisFiles=GetFiles(currentDirectory+"/**/*StyleCopAnalysis.xml");
		foreach(var analysisFile in styleCopAnalysisFiles)
		{   
			var  styleCopCheckIds =(from elements in System.Xml.Linq.XDocument.Load(analysisFile.FullPath).Descendants("Violation") 
						select elements).ToList();
		    
			   Information("StyleCop violations in {0} = {1}",analysisFile.GetFilenameWithoutExtension(), styleCopCheckIds.Count);
		  
		}
		
		if (!DirectoryExists("../../cireports/stylecop"))
		{
			CreateDirectory("../../cireports/stylecop");
		}
		
		MoveFiles(styleCopAnalysisFiles, "../../cireports/stylecop");
})
.OnError(exception =>
{
    FileWriteText("../cakelog.txt", "Error on Executing GetStyleCopReports:" + exception.ToString());
    throw new Exception("Cake process Failed on GetStyleCopReports Task");
});

Task("GetFxCopReports")
.Does(()=>
{
  EnsureDirectoryExists("../../cireports/fxcop");
		DeleteFiles("../../cireports/fxcop"+"/*FxCopAnalysis.xml");
		
		var fxCopAnalysisFiles=GetFiles(currentDirectory+"/**/*FxCopAnalysis.xml");
		foreach(var analysisFile in fxCopAnalysisFiles)
		{   
			var  fxCopCheckIds =(from elements in System.Xml.Linq.XDocument.Load(analysisFile.FullPath).Descendants("Issue") 
						select elements).ToList();
		    
			   Information("FxCop violations in {0} = {1}",analysisFile.GetFilenameWithoutExtension(), fxCopCheckIds.Count);		  
		}
		
		if (!DirectoryExists("../../cireports/fxcop"))
		{
			CreateDirectory("../../cireports/fxcop");
		}
		
		MoveFiles(fxCopAnalysisFiles, "../../cireports/fxcop");
})
.OnError(exception =>
{
    FileWriteText("../cakelog.txt", "Error on Executing GetFxCopReports:" + exception.ToString());
    throw new Exception("Cake process Failed on GetFxCopReports Task");
});



//code violation report
Task("CodeViolation") 
	//.IsDependentOn("GetFxCopReports")
	//.IsDependentOn("GetStyleCopReports")
    .Does(() =>
{	
});

Task("packnuget")
	.Does(() => {
	
		var nuspec = GetFiles("../**/*.nuspec").FirstOrDefault();

		var nuGetPackSettings = new NuGetPackSettings
		{  
			OutputDirectory = currentDirectory,
			BasePath = currentDirectory+"/bin/"+configuration,
			Version=studio_version[0]+"."+studio_version[1]+"."+studio_version[2]+"."+preReleaseNumber,
			ArgumentCustomization = args => args.Append("-Prop Configuration=" + configuration)
		};
			
		NuGetPack(nuspec.FullPath, nuGetPackSettings);


	});

Task("publish")
	.IsDependentOn("packnuget")
	.Does(()=>{

			var package = GetFiles(currentDirectory+"\\*.nupkg").FirstOrDefault();
			
			NuGetPush(package, new NuGetPushSettings 
			{
				Source = nugetserverurl,
				ApiKey = nugetapikey
			});

	});


Task("Default")
	.IsDependentOn("Clean")	
	.IsDependentOn("CopyrightandVersion")	
	.IsDependentOn("Restore-NuGet-Packages")
	.IsDependentOn("build");

RunTarget(target);
