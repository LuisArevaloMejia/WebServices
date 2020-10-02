using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Catalog
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WSBD.BaseDatosSoapClient WS = new WSBD.BaseDatosSoapClient();
            DataSet ds = WS.GetData();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind(); 
        }
    }
}