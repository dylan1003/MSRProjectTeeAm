## How to run the solution

### Note: this is a asp.net application and will only run on machines configured for asp.net e.g not .net core

#### Step One:
- Clone into visual studio 

#### Step Two:
- Set MSR_View project as 'start up project'

#### Step Three:
- Run & build project 



###### Key notes:
- MSR_View is simply the mvc application, while it does connect to a database it does not 
  require the project MSR_Database to be run or deployed.
- MSR_View accesses a remote azure database that this solution has read only access to. 
- MSR_Database is simply there to show you how the database is structured and how you can 
  populate the tables with data (./Scripts/PostDeploymentScript)

- The folder labeled DesignDocuments contains two sub folders:
  - Documents: Where the jpeg/pdf design documents are stored for viewing within github
  - Source: Where the source code/file to edit the above documents are. E.g xml for draw.io, or .docx for microsoft word files
