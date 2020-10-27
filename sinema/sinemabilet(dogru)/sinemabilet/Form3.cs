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
    public partial class Form3 : Form
    {

        
        public Form3()
        {
            InitializeComponent();
          
        }
        

        // public Form4 filmkoltuksec = new Form4();
        public bool _onay = false;
        public string _filmadi = "";

        private void Form3_Load(object sender, EventArgs e)
        {
            filmsecisimkaydırma.Enabled = true;
        }



        public void film1_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Bu filme bilet almak istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                _onay = true;
                _filmadi = "film1";

                Form3 kapa = new Form3();
                kapa.Close();
                Form4 form = new Form4();
                form.Show();
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Bu filme bilet almak istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                _onay = true;
                _filmadi = "film1";

                Form3 kapa = new Form3();
                kapa.Close();
                Form4 form = new Form4();
                form.Show();
            }

        }

        public void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Bu filme bilet almak istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                _onay = true;
                _filmadi = "film1";

                Form3 kapa = new Form3();
                kapa.Close();
                Form4 form = new Form4();
                form.Show();
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Bu filme bilet almak istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                _onay = true;
                _filmadi = "film1";

                Form3 kapa = new Form3();
                kapa.Close();
                Form4 form = new Form4();
                form.Show();
            }
        }

        public void button5_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Bu filme bilet almak istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                _onay = true;
                _filmadi = "film1";

                Form3 kapa = new Form3();
                kapa.Close();
                Form4 form = new Form4();
                form.Show();
            }
        }

        public void button10_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Bu filme bilet almak istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                _onay = true;
                _filmadi = "film1";

                Form3 kapa = new Form3();
                kapa.Close();
                Form4 form = new Form4();
                form.Show();
            }
        }

        public void button6_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Bu filme bilet almak istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                _onay = true;
                _filmadi = "film1";

                Form3 kapa = new Form3();
                kapa.Close();
                Form4 form = new Form4();
                form.Show();
            }
        }

        public void button7_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Bu filme bilet almak istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                _onay = true;
                _filmadi = "film1";

                Form3 kapa = new Form3();
                kapa.Close();
                Form4 form = new Form4();
                form.Show();
            }
        }

        public void button8_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Bu filme bilet almak istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                _onay = true;
                _filmadi = "film1";

                Form3 kapa = new Form3();
                kapa.Close();
                Form4 form = new Form4();
                form.Show();
            }
        }

        public void button9_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Bu filme bilet almak istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                _onay = true;
                _filmadi = "film1";

                Form3 kapa = new Form3();
                kapa.Close();
                Form4 form = new Form4();
                form.Show();
            }
        }








        public Button sender { get; set; }
    }
}
