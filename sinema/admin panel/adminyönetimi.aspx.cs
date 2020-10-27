using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_panel_adminyönetimi : System.Web.UI.Page
{
    Metodlar klas = new Metodlar();
    string aranacak = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            aranacak = Request.QueryString["aranacak"];
        }
        catch (Exception)
        {}
        if (aranacak != null)
        {
           
            DataTable dtara = klas.GetDataTable("SELECT dbo.kullanici.*, dbo.kullanicigrup.grupadi FROM dbo.kullanici INNER JOIN dbo.kullanicigrup ON dbo.kullanici.grupid = dbo.kullanicigrup.grupid where adsoyad like '%"+aranacak+"%'or kullaniciadi'%"+aranacak+"%'");
            dlara.DataSource = dtara;
            dlara.DataBind();

        }
    }
    protected void btnyönetici_Click(object sender, EventArgs e)
    {
        DataRow drkullanici = klas.GetDataRow("select grupid from kullanici where grupadi='"+"yönetici"+"'");
        DataTable dtkullanici = klas.GetDataTable("SELECT dbo.kullanici.*, dbo.kullanicigrup.grupadi FROM dbo.kullanici INNER JOIN dbo.kullanicigrup ON dbo.kullanici.grupid = dbo.kullanicigrup.grupid wheredbo.kullanici.grupid="+drkullanici["grupid"].ToString());
        dlkullanici.DataSource = dtkullanici;
        dlkullanici.DataBind();
        if (dtkullanici.Rows.Count == 0)
            dlkullanici.Visible = false;
        else
            dlkullanici.Visible = true;
    }
    protected void btnyardimci_Click(object sender, EventArgs e)
    {
        DataRow drkullanici = klas.GetDataRow("select grupid from kullanici where grupadi='" + "yardımcı yönetici" + "'");
        DataTable dtkullanici = klas.GetDataTable("SELECT dbo.kullanici.*, dbo.kullanicigrup.grupadi FROM dbo.kullanici INNER JOIN dbo.kullanicigrup ON dbo.kullanici.grupid = dbo.kullanicigrup.grupid wheredbo.kullanici.grupid=" + drkullanici["grupid"].ToString());
        dlkullanici.DataSource = dtkullanici;
        dlkullanici.DataBind();
        if (dtkullanici.Rows.Count == 0)
            dlkullanici.Visible = false;
        else
            dlkullanici.Visible = true;
    }
    protected void btnkullanici_Click(object sender, EventArgs e)
    {
        DataRow drkullanici = klas.GetDataRow("select grupid from kullanici where grupadi='" + "kullanıcı" + "'");
        DataTable dtkullanici = klas.GetDataTable("SELECT dbo.kullanici.*, dbo.kullanicigrup.grupadi FROM dbo.kullanici INNER JOIN dbo.kullanicigrup ON dbo.kullanici.grupid = dbo.kullanicigrup.grupid wheredbo.kullanici.grupid=" + drkullanici["grupid"].ToString());
        dlkullanici.DataSource = dtkullanici;
        dlkullanici.DataBind();
        if (dtkullanici.Rows.Count == 0)
            dlkullanici.Visible = false;
        else
            dlkullanici.Visible = true;
    }
    protected void btnson_Click(object sender, EventArgs e)
    {
        DataTable dtkullanici = klas.GetDataTable("SELECT top 20 dbo.kullanici.*, dbo.kullanicigrup.grupadi FROM dbo.kullanici INNER JOIN dbo.kullanicigrup ON dbo.kullanici.grupid = dbo.kullanicigrup.grupid");
        dlkullanici.DataSource = dtkullanici;
        dlkullanici.DataBind();
        if (dtkullanici.Rows.Count == 0)
            dlkullanici.Visible = false;
        else
            dlkullanici.Visible = true;
    }
    protected void btnara_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminyönetimi.aspx?aranacak="+Seo.Temizle(txtara.Text));
    }
}