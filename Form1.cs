using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CagriMerkeziUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Ad", 50);
            listView1.Columns.Add("Tel No", 30);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Ad, TelNo;
            Ad = textBox1.Text;
            TelNo = textBox2.Text;
            string[] bilgiler = { Ad, TelNo };
            ListViewItem kayit = new ListViewItem(bilgiler);
            listView1.Items.Add(kayit);
        }
    }
}
