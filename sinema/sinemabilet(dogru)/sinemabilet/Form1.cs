using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace sinemabilet
{
    public partial class Form1 : Form
    {
     
          
        
      
        public static string kullaniciadi, parola, vkullaniciadi, vparola;
       
        public Form1()
        {
            InitializeComponent();
       
        }
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sinema.mdb");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataTable tablo = new DataTable();
        public DataSet dset = new DataSet();

        

            //// Verileri Textbox üzerinden alalım ve bunları değişkenlere aktaralım.
          /*  kullaniciadi = textBox1.Text;
            parola = textBox2.Text;

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sinema.mdb");
            bag.Open();
            OleDbCommand kaydet = new OleDbCommand("SELECT *From Calisan", bag);
            OleDbDataReader oku = kaydet.ExecuteReader();
            while (oku.Read())
            {

                //    // Veritabanından çektiğimiz verileri değişkenlere aktaralım
                vkullaniciadi = oku[4].ToString();
                vparola = oku[5].ToString();

                if (kullaniciadi == vkullaniciadi && parola == vparola)
                {

                    //        // Kullanıcı var ise
                    Form1 kapa = new Form1();
                    kapa.Close();
                    Form2 form = new Form2();
                    form.Show();
                    this.Hide();

                    //        /*MessageBox.Show("Kullanıcı Var.");*/
              /*      //        return;
                }
                else
                {
                    //        // Kullanıcı yok ise
                    MessageBox.Show("Kullanıcı kayıtlı değil veya girdiğiniz bilgiler yanlış!", "Hata");
                }*/



        

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "ftm";
            textBox2.Text = "123";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* bag.Open();
           MessageBox.Show(bag.State.ToString());
           bag.Close();*/
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("select * from musteri where kullaniciadi='" + textBox1.Text + "'", bag);
            OleDbDataReader oku = kmt.ExecuteReader();

            while (oku.Read())
            {
                if (textBox1.Text.ToString() == oku["kullaniciadi"].ToString())
                {
                    if (textBox2.Text.ToString() == oku["parola"].ToString())
                    {

                        Form1 kapa = new Form1();
                        kapa.Close();
                        Form3 form = new Form3();
                        form.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("hata!!! Parola ya da Kullanıcı Adı Yanlıştır...!!");

                    }


                }


            }
            bag.Close();
        }

    

    /*    private void button2_Click(object sender, EventArgs e)
        {
            Form1 kapa = new Form1();
            kapa.Close();
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }*/

       
    }

       

}
    
