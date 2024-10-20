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
    public partial class KayıtOlForm : Form
    {
        public KayıtOlForm()
        {
            InitializeComponent();
        }

        sqlConnect bgl = new sqlConnect();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Kullanıcı (KullanıcıAd,Sifre) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kullanıcı kaydı oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
