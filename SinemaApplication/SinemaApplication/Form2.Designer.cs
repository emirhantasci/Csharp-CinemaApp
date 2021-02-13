
namespace SinemaApplication
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilmAdi2 = new System.Windows.Forms.TextBox();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.txtFilmSure = new System.Windows.Forms.TextBox();
            this.dtmpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbFilmTuru = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAfisSec = new System.Windows.Forms.Button();
            this.btnFilmiEkle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yönetmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vizyon Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Film Süresi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Film Türü";
            // 
            // txtFilmAdi2
            // 
            this.txtFilmAdi2.Location = new System.Drawing.Point(126, 31);
            this.txtFilmAdi2.Name = "txtFilmAdi2";
            this.txtFilmAdi2.Size = new System.Drawing.Size(250, 27);
            this.txtFilmAdi2.TabIndex = 5;
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(126, 64);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(250, 27);
            this.txtYonetmen.TabIndex = 6;
            // 
            // txtFilmSure
            // 
            this.txtFilmSure.Location = new System.Drawing.Point(126, 130);
            this.txtFilmSure.Name = "txtFilmSure";
            this.txtFilmSure.Size = new System.Drawing.Size(250, 27);
            this.txtFilmSure.TabIndex = 7;
            // 
            // dtmpTarih
            // 
            this.dtmpTarih.Location = new System.Drawing.Point(126, 97);
            this.dtmpTarih.Name = "dtmpTarih";
            this.dtmpTarih.Size = new System.Drawing.Size(250, 27);
            this.dtmpTarih.TabIndex = 9;
            // 
            // cmbFilmTuru
            // 
            this.cmbFilmTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmTuru.FormattingEnabled = true;
            this.cmbFilmTuru.Items.AddRange(new object[] {
            "Aksiyon",
            "Macera",
            "Animasyon",
            "Çocuk",
            "Komedi",
            "Suç",
            "Drama",
            "Epik",
            "Aile",
            "Fantazi",
            "Korku",
            "Müzikal",
            "Gerilim",
            "Aşk",
            "Bilim-Kurgu",
            "Spor",
            "Doğa üstü",
            "Gerilim",
            "Western"});
            this.cmbFilmTuru.Location = new System.Drawing.Point(126, 166);
            this.cmbFilmTuru.Name = "cmbFilmTuru";
            this.cmbFilmTuru.Size = new System.Drawing.Size(250, 28);
            this.cmbFilmTuru.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbFilmTuru);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtmpTarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFilmSure);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtYonetmen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFilmAdi2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(230, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 326);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Bilgileri";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(126, 201);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(250, 111);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Oyuncular";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(13, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnAfisSec
            // 
            this.btnAfisSec.Location = new System.Drawing.Point(13, 300);
            this.btnAfisSec.Name = "btnAfisSec";
            this.btnAfisSec.Size = new System.Drawing.Size(199, 38);
            this.btnAfisSec.TabIndex = 13;
            this.btnAfisSec.Text = "Afiş Seç";
            this.btnAfisSec.UseVisualStyleBackColor = true;
            this.btnAfisSec.Click += new System.EventHandler(this.btnAfisSec_Click);
            // 
            // btnFilmiEkle
            // 
            this.btnFilmiEkle.Location = new System.Drawing.Point(480, 344);
            this.btnFilmiEkle.Name = "btnFilmiEkle";
            this.btnFilmiEkle.Size = new System.Drawing.Size(145, 38);
            this.btnFilmiEkle.TabIndex = 14;
            this.btnFilmiEkle.Text = "Filmi Ekle";
            this.btnFilmiEkle.UseVisualStyleBackColor = true;
            this.btnFilmiEkle.Click += new System.EventHandler(this.btnFilmiEkle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(13, 352);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(94, 29);
            this.btnGeri.TabIndex = 15;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(637, 394);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnFilmiEkle);
            this.Controls.Add(this.btnAfisSec);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Film Ekle";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilmAdi2;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.TextBox txtFilmSure;
        private System.Windows.Forms.DateTimePicker dtmpTarih;
        private System.Windows.Forms.ComboBox cmbFilmTuru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAfisSec;
        private System.Windows.Forms.Button btnFilmiEkle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}