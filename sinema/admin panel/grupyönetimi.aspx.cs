using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class grupyönetimi : System.Web.UI.Page
{
    Metodlar klas = new Metodlar();
    string grupid = ""; string islem = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        grupid=Request.QueryString["grupid"];
        islem=Request.QueryString["islem"];

        if (islem == "sil")
        {
            klas.cmd("delete from kullanicigrup where grupid "+grupid);
        }
        DataTable dtgruplar = klas.GetDataTable("select* from kullanicigrup");
        rpgruplar.DataSource = dtgruplar;
        rpgruplar.DataBind();

    }
    protected void btnekle_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("insert into kullanicigrup(grupadi)values(@grupadi)",baglanti);
        cmd.Parameters.Add("grupadi",txtgrupadi.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("grupyönetimi.aspx");

    }
}