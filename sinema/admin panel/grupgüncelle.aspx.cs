using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class admin_panel_grupgüncelle : System.Web.UI.Page
{
    Metodlar klas=new Metodlar();
    string grupid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        grupid=Request.QueryString["grupid"];
       
        if (Page.IsPostBack == false)
        {
            DataRow drgrup = klas.GetDataRow("select * from kullanicigrup where grupid=" + grupid);
            txtgrup.Text = drgrup["grupadi"].ToString();
        }
    }
    protected void btndznle_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("update kullanicigrup set grupadi=@grupadi where grupid="+grupid,baglanti);
        cmd.Parameters.Add("grupadi",txtgrup.Text);
        cmd.EndExecuteNonQuery();
        Response.Redirect("grupyönetimi.aspx");
    }
}