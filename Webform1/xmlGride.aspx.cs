using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform1
{
    public partial class xmlGride : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("Countries.xml"));
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Label1.Text = "Data Accessed";

        }
            catch (FileNotFoundException Fnf)
            {
                Label1.Text = "File is Missing";
            }
            catch (System.UnauthorizedAccessException Uauthorized)
            {
                Label1.Text = "Unauthorized Access";
            }
            catch (Exception ex)
            {
                Label1.Text = "Some Unknown Error has occcured will get back to you Soon";
            }
            finally
            {
                //Label1.Text = "Done";
            }

        }

        protected void Page_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            Server.ClearError();
            Server.Transfer("error.aspx");

        }
    }
}
