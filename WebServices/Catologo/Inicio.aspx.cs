using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Catologo
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WSBD.BDSoapClient WS = new WSBD.BDSoapClient();
            DataSet ds = WS.GetData();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
    }
}