using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class admin_panel_login : System.Web.UI.Page
{
    Metodlar klas=new Metodlar();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btngiris_Click(object sender, EventArgs e)
    {
        DataRow drgiris = klas.GetDataRow("select * from where kullaniciadi='"+Seo.Temizle(txtkullaniciadi.Text)+"'and sifre='"+Seo.Temizle(txtsifre.Text)+"' grupaid=1" );
        if (drgiris != null)
        {
            Session["kullaniciid"] = drgiris["kullaniciid"].ToString();
            Response.Redirect("Default2.aspx");
        }
        else
            lblbilgi.Text = "Kullanıcı Adı veya Şifre Yanlış....!";
       
    }
}