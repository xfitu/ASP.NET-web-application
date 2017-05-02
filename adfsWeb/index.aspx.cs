using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.IdentityModel;
using Microsoft.IdentityModel.Claims;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		ClaimsIdentity identity = System.Threading.Thread.CurrentPrincipal.Identity as ClaimsIdentity;
        if (identity != null && identity.IsAuthenticated)
        {
            foreach (Claim claim in identity.Claims)
            {
                //Response.Write(claim.ClaimType+ " " + claim.Value + "\n");
                if (claim.ClaimType == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")
                {   //set user's name to hidden form value
                    Name.Value = claim.Value;
					usernameLabel.Text = claim.Value;
                    //Response.Write("name:" + " " + claim.Value + "\n");
                }
                if (claim.ClaimType == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role")
                {   //set user's role to hidden form value 
                    Role.Value = claim.Value;
                    //Response.Write("role:" + " " + claim.Value + "\n");
                }

                if (claim.ClaimType == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")
                {   //set user email address to hidden form value 
                    UserEmailaddress.Value = claim.Value;
                    //Response.Write("emailaddress:" + " " + claim.Value + "\n");
                }

                if (claim.ClaimType == "http://schemas.xmlsoap.org/claims/CommonName")	
                {   //show username on the header 
                    usernameLabel.Text = claim.Value;
                    //set username to hidden form value
                    Username.Value = claim.Value;
                    //Response.Write("username:" + " " + claim.Value + "\n");
                }
                
               
            }
        }
       
    }
}