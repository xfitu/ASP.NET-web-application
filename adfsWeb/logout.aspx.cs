using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		string absoluteUri = HttpContext.Current.Request.Url.AbsoluteUri;
		string loginPageUri = absoluteUri.Substring(0, absoluteUri.LastIndexOf("/") + 1)
		+ "Login.aspx";
		WSFederationAuthenticationModule.FederatedSignOut
		(null, new Uri("https://localhost:497/index.aspx"));

    }
	
	
	
	
}