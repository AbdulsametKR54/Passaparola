using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class SonucForm : Form
    {
        public SonucForm(string a, string b, string c, string d,string e)
        {
            InitializeComponent();
            soru = a;
            dsoru = b;
            ysoru = c;
            süre = d;
            bos = e;
        }

        string soru, dsoru, ysoru, süre, bos;
        private void SonucForm_Load(object sender, EventArgs e)
        {
            lblSoru.Text = int.Parse(soru) + 1 + "";
            lblDogru.Text = dsoru;
            lblYanlıs.Text = ysoru;
            lblGecen.Text = süre;
            lblBos.Text = bos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new OyunForm();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
