using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Data;

public partial class üyetamam : System.Web.UI.Page
{
Metodlar klas = new Metodlar();
string email = "";
int sayi;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            email=Request.QueryString["email"];
        }
        catch(Exception)
        { 

        }
        DataRow drsayi = klas.GetDataRow("select* from kullanici where email='"+email+"'");
        sayi = Convert.ToInt32(drsayi["sayi"].ToString());
        MailMessage msg = new MailMessage();
        msg.IsBodyHtml = true;
        msg.To.Add(email);
        msg.From = new MailAddress("fatmakurtulus4794qgmail.com", "sinemasyon.com", System.Text.Encoding.UTF8);
        msg.Subject = "konu";
        msg.Body="<a href='http://www.sinemasyon.com/uyeonay.aspx?x=" +sayi + "&email="+email+"'>üyelik onayı için tıklayın</a>";
        SmtpClient smp = new SmtpClient();
        smp.Credentials = new NetworkCredential("fatmakurtulus4794@mail.com","sifre");
        smp.Port = 587;
        smp.Host = "smtp.gmail.com";
        smp.EnableSsl = true;
        smp.Send(msg);

    }
}