<%@ Page Language="C#" AutoEventWireup="true" CodeFile="header.aspx.cs" Inherits="includes_header" %>

<!-- This file is the header of the web page that is included in the header required web pages  -->
<nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>                        
      </button>
      <a class="navbar-brand" style="color:white;">Health Portal</a>
    </div>
    <div class="collapse navbar-collapse" id="myNavbar">
      <ul class="nav navbar-nav">
        
      <li><a href="https://localhost:7443/ActiveDirectoryWebAPI/index.jsp"><span class="glyphicon glyphicon-home" style="font-size:20px;"></span></a></li>
      <li><a id="profilesettingsicon" href="https://localhost:7443/ActiveDirectoryWebAPI/profile.jsp"><span class="fa fa-cog" style="font-size:20px;"></span></a></li>     
      
	  </ul>
      <ul class="nav navbar-nav navbar-right">
	    
        <li><a href="#"><span id="usernameonicon" class="glyphicon glyphicon-user" style="font-size:20px;"></span>costa</a></li>
        <li>
		<a href="#"><span class="glyphicon glyphicon-log-out" style="font-size:18px;"></span>Log out</a>		
		</li>
      </ul>
    </div>
  </div>
</nav>
