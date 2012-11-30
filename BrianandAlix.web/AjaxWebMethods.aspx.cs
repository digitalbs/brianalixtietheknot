using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace BrianandAlix.web
{
    public partial class AjaxWebMethods : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [WebMethod]
        public static string submitRSVP(string values)
        {
            string blah = string.Empty;
            return blah;
        }
    }
}