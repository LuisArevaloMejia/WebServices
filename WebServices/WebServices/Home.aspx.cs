using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServices
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
            protected void Page_Load(object sender, EventArgs e)
            {
                WSBD.BDSoapClient WS = new WSBD.BDSoapClient();
                DataSet ds = WS.GetData();
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();

            }
        }
    }
}