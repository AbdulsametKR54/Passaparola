namespace Passaparola
{
    partial class SonucForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SonucForm));
            groupBox1 = new GroupBox();
            lblBos = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            lblGecen = new Label();
            lblYanlıs = new Label();
            lblDogru = new Label();
            lblSoru = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            lblText = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblBos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lblGecen);
            groupBox1.Controls.Add(lblYanlıs);
            groupBox1.Controls.Add(lblDogru);
            groupBox1.Controls.Add(lblSoru);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblText);
            groupBox1.Location = new Point(51, 23);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(331, 326);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sonuçlar:";
            // 
            // lblBos
            // 
            lblBos.AutoSize = true;
            lblBos.Location = new Point(241, 80);
            lblBos.Margin = new Padding(5, 0, 5, 0);
            lblBos.Name = "lblBos";
            lblBos.Size = new Size(80, 32);
            lblBos.TabIndex = 16;
            lblBos.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 80);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 15;
            label2.Text = "Boş Soru Sayısı:";
            // 
            // button2
            // 
            button2.Location = new Point(159, 265);
            button2.Name = "button2";
            button2.Size = new Size(106, 39);
            button2.TabIndex = 14;
            button2.Text = "Çıkış";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(37, 265);
            button1.Name = "button1";
            button1.Size = new Size(121, 39);
            button1.TabIndex = 2;
            button1.Text = "Tekrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblGecen
            // 
            lblGecen.AutoSize = true;
            lblGecen.Location = new Point(241, 204);
            lblGecen.Margin = new Padding(5, 0, 5, 0);
            lblGecen.Name = "lblGecen";
            lblGecen.Size = new Size(80, 32);
            lblGecen.TabIndex = 13;
            lblGecen.Text = "label7";
            // 
            // lblYanlıs
            // 
            lblYanlıs.AutoSize = true;
            lblYanlıs.Location = new Point(241, 163);
            lblYanlıs.Margin = new Padding(5, 0, 5, 0);
            lblYanlıs.Name = "lblYanlıs";
            lblYanlıs.Size = new Size(80, 32);
            lblYanlıs.TabIndex = 12;
            lblYanlıs.Text = "label6";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(241, 122);
            lblDogru.Margin = new Padding(5, 0, 5, 0);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(80, 32);
            lblDogru.TabIndex = 11;
            lblDogru.Text = "label2";
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(241, 38);
            lblSoru.Margin = new Padding(5, 0, 5, 0);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(80, 32);
            lblSoru.TabIndex = 10;
            lblSoru.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 204);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 32);
            label4.TabIndex = 9;
            label4.Text = "Geçen Süre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 38);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 32);
            label5.TabIndex = 8;
            label5.Text = "Soru Sayısı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 163);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(223, 32);
            label3.TabIndex = 5;
            label3.Text = "Yanlış Soru Sayısı:";
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(10, 122);
            lblText.Margin = new Padding(5, 0, 5, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(224, 32);
            lblText.TabIndex = 4;
            lblText.Text = "Doğru Soru Sayısı:";
            // 
            // SonucForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(462, 386);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "SonucForm";
            Text = "SonucForm";
            Load += SonucForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblGecen;
        private Label lblYanlıs;
        private Label lblDogru;
        private Label lblSoru;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label lblText;
        private Button button1;
        private Button button2;
        private Label lblBos;
        private Label label2;
    }
}