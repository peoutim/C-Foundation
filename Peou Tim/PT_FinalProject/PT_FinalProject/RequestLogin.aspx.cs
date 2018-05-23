using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using System.IO;

/// <summary>
/// Programmer" Peou Tim
///  HTML5 and CSS3 that write out data to text file.
/// </summary>

namespace PT_FinalProject
{
    public partial class RequestLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                var Name = Request["Name"];
                var EmailAddress = Request["EmailAddress"];
                var LoginName = Request["LoginName"];
                var Reason = Request["Reason"];

                //I borrow this code snippet from the Internet
                //Source:
                // I am sure there's a better way for this.                 

                var userData = Name + "," + EmailAddress +
                    "," + LoginName + "," + Reason + Environment.NewLine;

                var dataFile = Server.MapPath("~/App_Data/data.txt");
                File.WriteAllText(@dataFile, userData);

            }  //end write to file

        }
    }  //end class
}   //end NameSpace
