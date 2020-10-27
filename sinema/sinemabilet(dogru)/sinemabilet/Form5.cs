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
    public partial class Form5 : Form
    {
        public Form1 frm1;
        public Form5()
        {
            InitializeComponent();
        }
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sinema.mdb");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataTable tablo = new DataTable();
        public DataSet dset = new DataSet();
    
    }
}
