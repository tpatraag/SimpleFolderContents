using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleFolderContents
{
    public partial class _Default : Page
    {
        private string rootDir = ConfigurationManager.AppSettings["rootDir"];
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Directory.Exists(rootDir))
            {
                var contents = Directory.EnumerateFiles(rootDir);
                ddlDirectoryContents.DataSource = contents;
                ddlDirectoryContents.DataBind();
            }
        }
    }
}