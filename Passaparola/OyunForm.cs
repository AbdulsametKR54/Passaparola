using Timer = System.Windows.Forms.Timer;
using System.Data.SqlClient; 

namespace Passaparola
{
    public partial class OyunForm : Form
    {
        Timer? timer;
        public OyunForm()
        {
            InitializeComponent();
        }

        private void lblDogru_Click(object sender, EventArgs e)
        {

        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            lblDogru.Text = "Do�ru Soru Say�s�: " + dsoru;
            lblYanl�s.Text = "Yanl�� Soru Say�s�: " + ysoru;
            lblSoru.Text = "Soru Say�s�: " + soru;
            lblBosSoru.Text = "Bo� Soru Say�s�: " + bos;
            timer = new Timer();
            timer.Interval = 1000; // Her 1000 ms'de (1 saniye) bir tetiklenecek

            // Timer tick olay�: her tetiklendi�inde say�y� art�r ve label'a yazd�r
            timer.Tick += (sender, e) =>
            {
                zmn++;
                lblZmn.Text = $"S�re:+{zmn}"; // Artan say�y� g�ster
            };

            // Timer'� ba�lat
            timer.Start();
            lblHarf.Text = button1.Text;
            txtCevap.Enabled = true;
            btnStart.Visible = false;
            lblHarf.Visible = true;
            Questions();
            parola();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblHarf.Visible = false;
            txtCevap.Enabled = false;
            Random rnd = new Random();
            rastgeleSatir = rnd.Next(1, 2 + 1);
        }

        //AnswerBackCont
        int Counter = 1;

        //parola
        int clickCounter = 1;

        int soru = 0, dsoru = 0, ysoru = 0, zmn = 0, bos = 0;

        //baglant� s�n�f
        sqlConnect bgl = new sqlConnect();
        int ClickCounter = 1;
        //public int? SoruId;
        public int rastgeleSatir;
        public int Crick = 0;
        public void Questions()
        {
            string buttonName = $"button{ClickCounter}";
            Button? btn = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
            if (btn != null)
            {
                SqlCommand komut = new SqlCommand("Select * From Tbl_Sorular where Harf=@harf", bgl.baglanti());
                komut.Parameters.AddWithValue("@harf", btn.Text.ToUpper());
                SqlDataReader dr = komut.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    sayac++;
                    if (sayac == rastgeleSatir)
                    {
                        rctSoruText.Text = dr[2].ToString();
                        answer = dr[3].ToString();
                        soru++;
                        lblSoru.Text = "Soru Say�s�: " + soru;
                        break;
                    }
                }
                dr.Close();
                bgl.baglanti().Close();

                ClickCounter++;
            }
            else
            {
                ClickCounter = 1;
            }
        }
        string? answer;
        public string Answer()
        {
            return answer;
        }
        public void parola()
        {
            string buttonName = $"button{clickCounter}";
            Button? btn = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
            int sayac = 0;
            if (btn != null)
            {
                btn.BackColor = Color.Yellow;
                clickCounter++;
            }
            else
            {
                clickCounter = 1;
            }

        }
        public void AnswerBackCont(int a)
        {
            string buttonName = $"button{Counter}";
            Button? btn = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
            if (btn != null)
            {
                if (a == 1)
                {
                    btn.BackColor = Color.Green;
                }
                else if (a == -1)
                {
                    btn.BackColor = Color.Red;
                }
                else
                {
                    btn.BackColor = Color.Orange;
                }
                Counter++;
            }
            else
            {
                Counter = 1;
            }
        }

        bool? c;
        private void txtCevap_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int clck = clickCounter - 1; // 1 azalt
                string btnAd = $"button{clck}";
                Button btn2 = this.Controls.Find(btnAd, true).FirstOrDefault() as Button;
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtCevap.Text.ToLower() == Answer()?.ToLower())
                    {
                        dsoru++;
                        lblDogru.Text = "Do�ru Soru Say�s�: " + dsoru;
                        AnswerBackCont(1);
                    }
                    else if (txtCevap.Text != "")
                    {
                        ysoru++;
                        lblYanl�s.Text = "Yanl�� Soru Say�s�: " + ysoru;
                        AnswerBackCont(-1);
                    }
                    else
                    {
                        bos++;
                        lblBosSoru.Text = "Bo� Soru Say�s�: " + bos;
                        AnswerBackCont(0);
                    }
                    if (btn2.Text == "Z")
                    {
                        Form sonuc = new SonucForm(soru.ToString(), dsoru.ToString(), ysoru.ToString(), zmn.ToString(), bos.ToString());
                        sonuc.Show();
                        this.Close();
                    }
                    Questions();
                    parola();
                    txtCevap.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
