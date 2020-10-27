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
    public partial class Form2 : Form
    {
        //public Form1 frm1;
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sinema.mdb");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataTable tablo = new DataTable();
        public DataSet dset = new DataSet();

        void listele()
        {
            tablo.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select*from musteri",bag);
            adtr.Fill(tablo);
            adtr.Dispose();
            bag.Close();

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "")
            {
                MessageBox.Show("boş alanları dolduruz..");
            
            
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("kullanıcı adın giriniz...");

            }
                else if(textBox4.Text != textBox5.Text)
            {
                    MessageBox.Show("Parolalar uyuşmuyor");
                }
            else
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText="insert into musteri(adi,soyadi,kullaniciadi,parola,parola2) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5+"')";
                kmt.ExecuteNonQuery();
                bag.Close();
                listele();
                MessageBox.Show("Kaydınız Tamamlandı.","Kayıt Bşarılı =))",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            
            }

        }

       
    }
}
