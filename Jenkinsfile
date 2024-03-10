node('content')
{ 
timestamps
  {
  
  def Content="";
		env.PATH = "${ProgramFiles}"+"\\Git\\mingw64\\bin;${env.PATH}"  

     timeout(time: 7200000, unit: 'MILLISECONDS') {
    String platform='maui';
   try
	{   
		//Clone scm repository in Workspace source directory
		stage ('Checkout')   
	    { 
	    dir('Spell-Checker') 
           {
		     checkout scm
			 


			def branchCommit = 'https://api.github.com/repos/syncfusion-content/'+env.githubSourceRepoHttpUrl.split('/')[env.githubSourceRepoHttpUrl.split('/').size() - 1]+'/pulls/' + env.pullRequestId + '/files'
            String branchCommitDetails = bat returnStdout: true, script: 'curl -H "Accept: application/vnd.github.v3+json" -u SyncfusionBuild:' + env.GithubBuildAutomation_PrivateToken + " " + branchCommit

            def ChangeFiles= branchCommitDetails.split('"filename": ');

            for (int i= 1; i < ChangeFiles.size();i++)
            {
            def ChangeFile= ChangeFiles[i].split(',')[0].replace('"', '')
            Content += env.WORKSPACE + "\\Spell-Checker\\" + ChangeFile + "\r\n";
            }

		    
		      if (Content) {  
                 writeFile file: env.WORKSPACE+"/cireports/content.txt", text: Content
              }
              else  {
                writeFile file: env.WORKSPACE+"/cireports/content.txt", text: "There are no filepaths found for this commit."
              }
		    }
		    }
			 
		   //Checkout the ug_spellchecker from development Source
	  checkout([$class: 'GitSCM', branches: [[name: '*/development']], doGenerateSubmoduleConfigurations: false, extensions: [[$class: 'RelativeTargetDirectory', relativeTargetDir: 'ug_spellchecker']], submoduleCfg: [], userRemoteConfigs: [[credentialsId: env.githubCredentialId, url: 'https://github.com/syncfusion-content/ug_spellchecker.git']]])
		 
	  }
	  
	 
	
	
    catch(Exception e)
    {
		currentBuild.result = 'FAILURE'
    } 

if(currentBuild.result != 'FAILURE')
{ 
	stage 'Build Source'
	try
	{
	    gitlabCommitStatus("Build")
		{
		bat 'powershell.exe -ExecutionPolicy ByPass -File '+env.WORKSPACE+"/ug_spellchecker/build.ps1 -Script "+env.WORKSPACE+"/ug_spellchecker/build.cake -Target build -Platform \""+platform+"\" -Targetbranch "+env.githubTargetBranch+" -Branch "+'"'+env.githubSourceBranch+'"'
	 	}
	 	
	 	def files = findFiles(glob: '**/cireports/errorlogs/*.txt')
 
        if(files.size() > 0)
        {
           currentBuild.result = 'FAILURE'
        }
	 	
    }
	 catch(Exception e) 
    {
		currentBuild.result = 'FAILURE'
    }
}	

	stage 'Delete Workspace'
	
		def files = findFiles(glob: '**/cireports/*.*')      
        
    if(files.size() > 0) 		
    { 		
         archiveArtifacts artifacts: 'cireports/', excludes: null 	 
    }
	    step([$class: 'WsCleanup'])	}
	    }
}
