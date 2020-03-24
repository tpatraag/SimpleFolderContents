using System;
using System.Configuration;
using System.IO;
using System.Web.UI;

namespace SimpleFolderContents
{
    public partial class _Default : Page
    {
        private string rootDir = ConfigurationManager.AppSettings["rootDir"];
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lblDirContents.Text = $"Directory Contents List for {rootDir}";
                //if (Directory.Exists(rootDir))
                //{
                    var contents = Directory.EnumerateFiles(rootDir);
                    ddlDirectoryContents.DataSource = contents;
                    ddlDirectoryContents.DataBind();
                //}
                //lblError.Text = "Directory doesn't exists for me";
                //lblError.Visible = true;
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message + "<br>" + ex.StackTrace;
                lblError.Visible = true;
            }
        }
    }
}