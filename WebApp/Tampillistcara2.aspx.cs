using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Tampillistcara2 : System.Web.UI.Page
    {
        private OnlineRaporEntities entities = new OnlineRaporEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var t = from x in entities.ASPEK
                    select x;
            GridView1.DataSource = t.ToList();
            GridView1.DataBind();

        }
    }
}