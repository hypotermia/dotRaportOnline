using Raport_Online;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Form : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Raport_Online.JABATAN jabat = new Raport_Online.JABATAN
            {
                NAMA_JABATAN = TextBox1.Text,
                DIBUAT_OLEH = TextBox2.Text,
                DIBUAT_PADA = DateTime.Now,
                STATUS_AKTIF = CheckBox1.Checked
            };
            JabatanDAO jabatandao = new JabatanDAO();
            jabatandao.Add(jabat);
            
        }
    }
}