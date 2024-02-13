using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginUtente
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["loginCookie"] != null) { Response.Redirect("Home.aspx"); }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
         if (loginText.Text != ""){ 
            HttpCookie cookie = new HttpCookie("loginCookie");
            cookie.Values["username"] = loginText.Text;
            Response.Cookies.Add(cookie);
            Response.Redirect("Home.aspx");
            }
            else { labels.Text = "Inserisci un username per continure"; }

        }
    }
}