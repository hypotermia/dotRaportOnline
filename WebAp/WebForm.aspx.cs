using Raport_Online;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAp
{
    public partial class WebForm : System.Web.UI.Page
    {
        //private OnlineRaporEntities context = new OnlineRaporEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ASPEK aspek = new ASPEK
            {
                NAMA_ASPEK = TextBox1.Text,
                DIBUAT_OLEH = TextBox2.Text,
                DIBUAT_PADA = DateTime.Now,
                STATUS_AKTIF= CheckBox1.Checked
            };
            AspekDAO aspdao = new AspekDAO();
            aspdao.Add(aspek);
            
        }

       
    }
}