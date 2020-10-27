using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace sinemabilet
{
    public partial class Form4 : Form
    {
       
        public decimal Fiyat { get; set; }
        public Form1 frm1;
        public int saydir;
        public object koltuklar;

        public Form4()
        {
            InitializeComponent();
            //A1.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //A2.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //A3.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //A4.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //A5.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //A6.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //A7.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //A8.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //A9.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //B1.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //B2.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //B3.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //B4.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //B5.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //B6.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //B7.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //B8.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //B9.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //C1.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //C2.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //C3.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //C4.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //C5.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //C6.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //C7.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //C8.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //C9.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //D1.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //D2.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //D3.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //D4.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //D5.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //D6.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //D7.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //D8.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //D9.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //E1.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //E2.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //E3.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //E4.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //E5.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //E6.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //E7.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //E8.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            //E9.MouseClick += new MouseEventHandler(tıklama_MouseClick);
            KirmiziYap();
            seans();
            film();
        }
        
        private void KirmiziYap()
        {
             A1.BackColor = Color.Red;
            A2.BackColor = Color.Red;
            A3.BackColor = Color.Red;
            A4.BackColor = Color.Red;
            A5.BackColor = Color.Red;
            A6.BackColor = Color.Red;
            A7.BackColor = Color.Red;
            A8.BackColor = Color.Red;
            A9.BackColor = Color.Red;
            B1.BackColor = Color.Red;
            B2.BackColor = Color.Red;
            B4.BackColor = Color.Red;
            B3.BackColor = Color.Red;
            B7.BackColor = Color.Red;
            B5.BackColor = Color.Red;
            B6.BackColor = Color.Red;
            B8.BackColor = Color.Red;
            B9.BackColor = Color.Red;
            C1.BackColor = Color.Red;
            C2.BackColor = Color.Red;
            C4.BackColor = Color.Red;
            C3.BackColor = Color.Red;
            C7.BackColor = Color.Red;
            C5.BackColor = Color.Red;
            C6.BackColor = Color.Red;
            C8.BackColor = Color.Red;
            C9.BackColor = Color.Red;
            D1.BackColor = Color.Red;
            D2.BackColor = Color.Red;
            D4.BackColor = Color.Red;
            D3.BackColor = Color.Red;
            D7.BackColor = Color.Red;
            D5.BackColor = Color.Red;
            D6.BackColor = Color.Red;
            D8.BackColor = Color.Red;
            D9.BackColor = Color.Red;
            E1.BackColor = Color.Red;
            E2.BackColor = Color.Red;
            E4.BackColor = Color.Red;
            E3.BackColor = Color.Red;
            E7.BackColor = Color.Red;
            E5.BackColor = Color.Red;
            E6.BackColor = Color.Red;
            E8.BackColor = Color.Red;
            E9.BackColor = Color.Red;
            
        }
        public void seans()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "select saat from seans";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboSeans.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
        }
        public void film()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "select adi from film";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                combofilm.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
        }
        void listele()
        {
            tablo.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select*from bilet", bag);
            adtr.Fill(tablo);
            adtr.Dispose();
            bag.Close();



        }

        public Button tıklananbuton;
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sinema.mdb");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataTable tablo = new DataTable();
        public DataSet dset = new DataSet();
        public int KisiID;
        int boskoltuklar = 45;
        int dolukoltuklar;

        void tıklama_MouseClick(object sender, EventArgs e)
        {
           var xbutton = (Button) sender;
            if (xbutton.BackColor == Color.Red)
            {
                rdbögrenci.Checked = true; 

                xbutton.BackColor = Color.Green;
           }
            else
            {
                xbutton.BackColor = Color.Red;
                txtsecilenkoltuk.Clear();
               
                
            }
            var button = (Button)sender;
            if (button.BackColor == Color.Red)
            {
                button.Enabled = false;
                button.BackColor = Color.Green;
            }


            var koltuklar = txtsecilenkoltuk.Text.Split(';');

            if (rdbögrenci.Checked)
            {
                kmt.Parameters.AddWithValue("SecilenTarife", "Öğrenci");
                Fiyat = 10;
            }
            else if (rdbtam.Checked)
            {
                kmt.Parameters.AddWithValue("SecilenTarife", "Tam");
                Fiyat = 12;

            }
            txtfiyat.Text = (Fiyat * koltuklar.Length).ToString();
            lblboskoltuksayisi.Text = (45 - koltuklar.Length).ToString();
            lbldolukoltuksayisi.Text = koltuklar.Length.ToString();
           
            
            //var button = (Button)sender;
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
                OleDbCommand kmt = new OleDbCommand();
                kmt.Connection = bag;
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }

                kmt.CommandText = "insert into tiklanankoltuklar(tiklanankoltuklar)values(tiklanankoltuklar)";
                kmt.Parameters.AddWithValue("tiklanankoltuklar", button.Text);
                kmt.ExecuteNonQuery();
                bag.Close();

              /*  if (button.BackColor == Color.Red)
                {
                    //button.Enabled = false;
                   button.BackColor = Color.Green;
                }*/
                boskoltuklar--;
                dolukoltuklar++;
                lblboskoltuksayisi.Text = boskoltuklar.ToString();
                lbldolukoltuksayisi.Text = dolukoltuklar.ToString();
                if (txtsecilenkoltuk.Text == "")
                {
                    grpmenu.Enabled = false;
                    txtsecilenkoltuk.Text = button.Name.ToString();

                }
                else
                {
                    grpmenu.Enabled = false;
                    txtsecilenkoltuk.Text += ";" + button.Name.ToString();

                }
                
            }
        }
        
        private void Form5_Load(object sender, EventArgs e)
        {
            

            saatgösterici.Interval = 50;
            txttarih.Text = DateTime.Today.ToShortDateString();
            if (bag.State == ConnectionState.Closed)
                bag.Open();
            OleDbCommand kmt = new OleDbCommand("select secilenkoltuk from bilet", bag);
            OleDbDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                foreach (Control item in this.grpkoltuklar.Controls)
                {
                    if (item is Button)
                    {
                        string koltuk = dr["SecilenKoltuk"].ToString();
                        int bul = koltuk.IndexOf(';');
                        if (bul > 0)
                        {
                            string[] secilenKoltuk = koltuk.Split(';');
                            for (int k = 0; k <= secilenKoltuk.Length - 1; k++)
                            {
                                if (item.Name == secilenKoltuk[k])
                                {
                                    item.Enabled = false;
                                    item.BackColor = Color.Red;
                                    dolukoltuklar++;
                                    boskoltuklar--;
                                    lbldolukoltuksayisi.Text = dolukoltuklar.ToString();
                                    lblboskoltuksayisi.Text = boskoltuklar.ToString();



                                }

                            }

                        }
                        else
                        {
                            if (item.Name == dr["secilenkoltuk"].ToString())
                            {
                                item.Enabled = false;
                                item.BackColor = Color.Red;
                                dolukoltuklar++;
                                boskoltuklar--;
                                lbldolukoltuksayisi.Text = dolukoltuklar.ToString();
                                lblboskoltuksayisi.Text = boskoltuklar.ToString();


                            }

                        }
                    }

                }
            }
        }
        void temizle()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand();
            kmt.Connection = bag;
            kmt.CommandText = ("delete tiklanankoltuklar(tiklanankoltuklar)");
            txtsaat.Clear();
            txttarih.Clear();
            txtfiyat.Clear();
            txtIsim.Clear();
            
            txtsecilenkoltuk.Clear();
            txtSoyisim.Clear();
           // kmt.ExecuteNonQuery();
            bag.Close();

        }

        private void btnBiletIptal_Click(object sender, EventArgs e)
        {
            KirmiziYap();
          
            return;

        }

        /* if (bag.State == ConnectionState.Closed)
         {
             bag.Open();
             OleDbCommand kmt = new OleDbCommand("select tiklanankoltuklar from tiklanankoltuklar", bag);
             OleDbDataReader dr = kmt.ExecuteReader();
             ArrayList secilenkoltuklar = new ArrayList();
             DialogResult cevap;
             cevap = MessageBox.Show("Bilet Alma İşlemini İptal Etmek İstediğinize Eminsiniz!!!");
             if (cevap == DialogResult.Yes)
             {
                 while (dr.Read())
                 {
                     foreach (Control item in this.grpkoltuklar.Controls)
                     {
                         if (item is Button)
                         {
                             string koltuk = dr["TiklananKoltuklar"].ToString();
                         }
                     }
                 }
             }


         }*/

        private void btnsatinal_Click(object sender, EventArgs e)
        {

            if (txtIsim.Text == "" && txtSoyisim.Text == "")
            {
                MessageBox.Show("Boş Alanları Dolduruz!!!!");
            }
            lblsaat.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToShortTimeString();
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("select * from bilet");
            kmt.Connection = bag;
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
               
            }
          
            KirmiziYap();
            if (btnsatinal.Text == "Satın Al")
            {
                
                kmt.Connection = bag;
                kmt.CommandText = "insert into Bilet (Isim,SoyIsim,BiletiAldigiGun,BiletiAldigiSaat,SecilenFİlm,secilenkoltuk,Fiyat)values ('" + txtIsim.Text + "','" + txtSoyisim.Text + "','" + txttarih.Text + "','" + txtsaat.Text + "','" + txtsecilenkoltuk.Text + "','" + txtfiyat.Text + "' )";
                kmt.ExecuteNonQuery();
                string koltuk = txtsecilenkoltuk.ToString();
                string[] koltuklar = koltuk.Split(';');
                int koltukadeti = koltuklar.Length;
                int fiyat = 0;
                if (rdbögrenci.Checked == true)
                {
                    kmt.Parameters.AddWithValue("SecilenTarife", "Öğrenci");
                    fiyat = 10;
                }
                else if (rdbtam.Checked == true)
                {
                    kmt.Parameters.AddWithValue("SecilenTarife", "Tam");
                    fiyat = 12;

                }
                int ToplamBedel = fiyat * koltukadeti;
                kmt.Parameters.AddWithValue("fiyat", ToplamBedel);
                kmt.ExecuteNonQuery();
             
                bag.Close();
              

                this.Hide();
                listele();
                MessageBox.Show("Bilet Alınmıştır..", "Durum");
             
               // temizle();

                //btnsatinal.Enabled = true;
                //tnfilmsec.Enabled = true;
                //btnBiletIptal.Enabled = true;
                //grpmenu.Enabled = true;
                //grpkoltuklar.Enabled = true;
                Form4 kapa = new Form4();
                kapa.Close();
                this.Hide();
             
                bag.Close();
            

            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txttarih.Text = DateTime.Now.ToLongDateString();
            txtsaat.Text = DateTime.Now.ToShortTimeString();
            
        }


    

    }
}
    
     
     
            

     
















