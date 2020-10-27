using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class uyeonay : System.Web.UI.Page
{
    string x = "";
    string email = "";
Metodlar klas = new Metodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        try 
        { 
            x = Request.QueryString["x"];
            email = Request.QueryString["x"];
        }
        catch (Exception)
        {
        }
        DataRow drsayi = klas.GetDataRow("select sayi from kullanici where email='"+email+"'");
        if (x == drsayi["sayi"].ToString())
        {
            klas.cmd("update kullanici set onay=1 where email='" + email + "' ");
        }
    }
}