# ASP.NET-web-application
Claims-aware  ASP.NET web application which uses WS-Federation protocol to communicate with ADFS 3.0 server (Windows Server 2012 R2) for user authentication and ADFS server returns security token (saml 2.0) which contains claims about the authenticated user to be used by this claims-aware application for authorization. The core functionalities of the application are; users can make self-registration or create account in Active Directory via web interface and connect to Active Directory Federation Server (ADFS) so user can authenticate with Active Directory Account. On successful authentication the Application will receive Claims(e.g.username,name,and role) from the ADFS Server and decides which pages can be accessed by each user based user's role in the claims(roles:doctor or patient).This application uses Java Servlet API(https://github.com/xfitu/WebAPI) for creating new user account, add, delete, and update user's attributes in Active Directory(AD DS) and Windows Identity Foundation (WIF library in ASP.NET framework 4.0 in visual studio 2010) to communicate with Active Directory Federation Services (AD FS) server.

Development Steps:
------------------
1) Creating the web application using Microsoft Visual Studio 2010
2) Install WIF(https://msdn.microsoft.com/en-us/library/hh545401(v=vs.110).aspx) SDK in visual studio
3) Use the WIF SDK to make the web application as claims-aware web application.a metadata will be created for the web application
4) Creating Relying Party Trusts for the  web application on ADFS server management console and configure using metadata created in step 3
5) Creating claims rules for sending user's details such as sAMAccount,name,role(use group membership value as role value e.g. doctor and    patient)

USAGE
-----
1) Open Browser navigate to ADFS sample (Eg: In our case https://localhost/Adfsweb/) index page will be displayed.
2) Click on login button on index page
3) You will be redirected to ADFS server login page
3) Enter valid Active directory user credentials and click signin
4) ADFS server will redirect to Active Directory adfsweb application with security token(ST) which contains claims about the        	        authenticated user
