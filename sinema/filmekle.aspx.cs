using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class filmekle : System.Web.UI.Page
{
Metodlar klas = new Metodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            ddfilmtür.Items.Insert(0, new ListItem("seciniz", "0"));
            tur();
            yeri();
            yili();
        }
    }
    void tur()
    {
        DataTable dttur = klas.GetDataTable("select *from turler order by [turadi]");
        ddfilmtür.DataTextField = "turadi";
        ddfilmtür.DataValueField = "turid";
        ddfilmtür.DataSource = dttur;
        ddfilmtür.DataBind();
           
    }
    void yeri()
    {
        DataTable dtyeri = klas.GetDataTable("select *from yapimyeri order by [yapimadi]");
        ddyyeri.DataTextField = "yapimadi";
        ddyyeri.DataValueField = "yapimid";
        ddyyeri.DataSource = dtyeri;
        ddyyeri.DataBind();
    }
    void yili()
    {

        DataTable dtyili = klas.GetDataTable("select *from yapimyili order by [yiladi]");
        ddyyılı.DataTextField = "yiladi";
        ddyyılı.DataValueField = "yilid";
        ddyyılı.DataSource = dtyili;
        ddyyılı.DataBind();
    }
    protected void btnkaydet_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("insert into film (tarih,filmadi,türid,yilid,yapimid,oyuncuid,yönetmenid,senaryoid,konuid,yapimciid)values(@tarih,@filmadi,@türid,@yilid,@yapimid,@oyuncuid,@yönetmenid,@senaryoid,@konuid,@yapimciid)", baglanti);
        cmd.Parameters.Add("türid", ddfilmtür.SelectedValue);
       
        cmd.Parameters.Add("filmadi", txtfilmadi.Text);
        cmd.Parameters.Add("yilid", ddyyılı.SelectedValue);
        cmd.Parameters.Add("yapimid", ddyyeri.SelectedValue);
        cmd.Parameters.Add("oyuncuid", txtync.Text);
        cmd.Parameters.Add("yönetmenid",txtyntmn.Text);
        cmd.Parameters.Add("senaryoid",txtsnry.Text);
        cmd.Parameters.Add("konuid",txtkonu.Text);
        cmd.Parameters.Add("yapimciid",txtyapimci.Text);
        cmd.Parameters.Add("kullaniciid","1");
        cmd.Parameters.Add("turid", ddfilmtür.SelectedValue);
        cmd.Parameters.Add("tarih",DateTime.Now.ToString());
        cmd.ExecuteNonQuery();
      
    }
}