using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Passaparola
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new KayıtOlForm();
            frm.Show();
            this.Close();
        }

        sqlConnect bgl= new sqlConnect();
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select KullanıcıAd,Sifre From Tbl_Kullanıcı where KullanıcıAd=@p1 and Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                Form form=new OyunForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre girişi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
            
        }
    }
}
