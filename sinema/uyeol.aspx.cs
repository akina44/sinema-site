using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

using System.Data.SqlClient;using System.Data;

public partial class uyeol : System.Web.UI.Page
{
    int sayi;
    int sayi2;
    Metodlar klas = new Metodlar();
    protected void Page_Load(object sender, EventArgs e)
    {
        Random sayi2 = new Random();
        sayi = sayi2.Next();
        if (Page.IsPostBack == false)
        {
            meslek();
            drpmeslek.Items.Insert(0,new ListItem("seçiniz,0"));
        }
    }
    void meslek()
    {
        DataTable dtmeslek = klas.GetDataTable("select* from meslek " + "order by[meslekadi]");
        drpmeslek.DataTextField = "meslekadi";
        drpmeslek.DataValueField = "meslekid";
        drpmeslek.DataSource = dtmeslek;
        drpmeslek.DataBind();
    }
    protected void btnkaydet_Click(object sender, EventArgs e)
    {
        string cinsiyet = "";
        string resimadi = "";
        string uzanti = ""; 
        

        if (rderkek.Checked)
            cinsiyet = "erkek";
        else
            cinsiyet = "bayan";
        DataRow drmail =klas.GetDataRow("select*from kullanici where email='"+txtemail.Text+"'");
        //resim yükleme
        if (flresim.HasFile)
        {
            uzanti = Path.GetExtension(flresim.PostedFile.FileName);
            resimadi = Seo.Temizle(txtemail.Text) + DateTime.Now.Day + uzanti;
            flresim.SaveAs(Server.MapPath("kul-resim/silinecek" + uzanti));
            int deger = 250;
            Bitmap resim = new Bitmap(Server.MapPath("kul-resim/silinecek"));
            using (Bitmap yeniresim = resim)
            {
                double yukseklik = yeniresim.Height;
                double genislik = yeniresim.Width;
                double oran = 0;
                if (genislik >= deger)
                {
                    oran = genislik / yukseklik;
                    genislik = deger;
                    yukseklik = deger / oran;

                    Size yenideger = new Size(Convert.ToInt32(genislik), Convert.ToInt32(yukseklik));
                    Bitmap sonresim = new Bitmap(yeniresim, yenideger);
                    sonresim.Save(Server.MapPath("kul-resim/" + resimadi));

                    sonresim.Dispose();
                    yeniresim.Dispose();
                    resim.Dispose();

                }
                else
                {
                    flresim.SaveAs(Server.MapPath("kul-resim/silinecek" + uzanti));

                }
                FileInfo fsilinecek = new FileInfo(Server.MapPath("kul-resim/silinecek" + uzanti));
                fsilinecek.Delete();
            }
        }
        else
        {
            if (rderkek.Checked)
                resimadi = "erkek.png";
            else
                resimadi = "bayan.png";

        }
       
        if(drmail==null)
        {
           
        SqlConnection baglanti = klas.baglan();
        SqlCommand cmd = new SqlCommand("insert into kullanici(email,sifre,adsoyad,kullaniciadi,meslekid,cinsiyet,dogumtarihi,resim,sayi)values(@email,@sifre,@adsoyad,@kullaniciadi,@meslekid,@cinsiyet,@dogumtarihi,@resim,@sayi)");
        cmd.Parameters.Add("email",Seo.Temizle(txtemail.Text));
        cmd.Parameters.Add("adsoyad",Seo.Temizle(txtadsoyad.Text));
        cmd.Parameters.Add("kullaniciadi",Seo.Temizle( txtkullaniciadi.Text));
        cmd.Parameters.Add("meslekid",drpmeslek.SelectedValue );
        cmd.Parameters.Add("dogumtarihi",Seo.Temizle( txtemail.Text));
        cmd.Parameters.Add("cinsiyet",cinsiyet);
        cmd.Parameters.Add("dogumtarihi",Seo.Temizle( txtdogum.Text));
        cmd.Parameters.Add("sifre", Seo.Temizle(txtsifre.Text));
        cmd.Parameters.Add("resim",resimadi);
        cmd.Parameters.Add("sayi",sayi);
        cmd.ExecuteNonQuery();
        Response.Redirect("üyetamam.aspx?email="+txtemail.Text);
        }
        else
        lblbilgi.Text="bu email adresi sitede kayıtlı.";
    }
}
   