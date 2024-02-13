using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginUtente
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["loginCookie"] != null) { Labels1.Text = $"Benvenuto {Request.Cookies["loginCookie"]["username"]}";

            }
            else { logoutBtn.Visible = false;
                Response.Redirect("Login.aspx");
            }

        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["loginCookie"] != null)
            {
                Response.Cookies["loginCookie"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("Login.aspx");
            }
        }
    }
}