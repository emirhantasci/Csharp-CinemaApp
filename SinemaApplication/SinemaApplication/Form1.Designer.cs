
namespace SinemaApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.btnSeansListele = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbKoltukIptal = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSatis = new System.Windows.Forms.Button();
            this.txtKoltuk = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.cmbFilmSeansi = new System.Windows.Forms.ComboBox();
            this.cmbFilmTarihi = new System.Windows.Forms.ComboBox();
            this.cmbFilmAdi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFilmOyuncular = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblFilmSure = new System.Windows.Forms.Label();
            this.lblFilmYonetmen = new System.Windows.Forms.Label();
            this.lblFilmVizyon = new System.Windows.Forms.Label();
            this.lblFilmTuru = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.btnSatislar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnSalonEkle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalonEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalonEkle.ImageIndex = 6;
            this.btnSalonEkle.ImageList = this.ımageList1;
            this.btnSalonEkle.Location = new System.Drawing.Point(56, 12);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(121, 70);
            this.btnSalonEkle.TabIndex = 0;
            this.btnSalonEkle.Text = "Salon Ekle";
            this.btnSalonEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalonEkle.UseVisualStyleBackColor = false;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "film.png");
            this.ımageList1.Images.SetKeyName(1, "kapat.png");
            this.ımageList1.Images.SetKeyName(2, "liste.ico");
            this.ımageList1.Images.SetKeyName(3, "seans.jpg");
            this.ımageList1.Images.SetKeyName(4, "seanss.png");
            this.ımageList1.Images.SetKeyName(5, "salon.jpg");
            this.ımageList1.Images.SetKeyName(6, "3028292.png");
            this.ımageList1.Images.SetKeyName(7, "sale.png");
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFilmEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilmEkle.ImageIndex = 0;
            this.btnFilmEkle.ImageList = this.ımageList1;
            this.btnFilmEkle.Location = new System.Drawing.Point(183, 12);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(121, 70);
            this.btnFilmEkle.TabIndex = 1;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // btnSeansEkle
            // 
            this.btnSeansEkle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeansEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeansEkle.ImageIndex = 4;
            this.btnSeansEkle.ImageList = this.ımageList1;
            this.btnSeansEkle.Location = new System.Drawing.Point(310, 11);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(121, 70);
            this.btnSeansEkle.TabIndex = 2;
            this.btnSeansEkle.Text = "Seans Ekle";
            this.btnSeansEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeansEkle.UseVisualStyleBackColor = true;
            this.btnSeansEkle.Click += new System.EventHandler(this.btnSeansEkle_Click);
            // 
            // btnSeansListele
            // 
            this.btnSeansListele.BackColor = System.Drawing.Color.Transparent;
            this.btnSeansListele.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeansListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeansListele.ImageIndex = 2;
            this.btnSeansListele.ImageList = this.ımageList1;
            this.btnSeansListele.Location = new System.Drawing.Point(437, 11);
            this.btnSeansListele.Name = "btnSeansListele";
            this.btnSeansListele.Size = new System.Drawing.Size(121, 70);
            this.btnSeansListele.TabIndex = 3;
            this.btnSeansListele.Text = "Seanslar";
            this.btnSeansListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeansListele.UseVisualStyleBackColor = false;
            this.btnSeansListele.Click += new System.EventHandler(this.btnSeansListele_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ImageIndex = 1;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(1087, 602);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(83, 66);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(718, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 354);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtUcret);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSatis);
            this.groupBox1.Controls.Add(this.txtKoltuk);
            this.groupBox1.Controls.Add(this.txtTelNo);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.cmbSalon);
            this.groupBox1.Controls.Add(this.cmbFilmSeansi);
            this.groupBox1.Controls.Add(this.cmbFilmTarihi);
            this.groupBox1.Controls.Add(this.cmbFilmAdi);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(56, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 627);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış";
            // 
            // txtUcret
            // 
            this.txtUcret.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUcret.Location = new System.Drawing.Point(146, 289);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(196, 31);
            this.txtUcret.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(7, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 23);
            this.label13.TabIndex = 16;
            this.label13.Text = "Ücret";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(6, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "Koltuk No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(7, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tel. NO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(7, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ad - Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(7, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Salon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(7, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Film Seansı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIptal);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmbKoltukIptal);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(20, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 156);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İptal";
            // 
            // btnIptal
            // 
            this.btnIptal.ForeColor = System.Drawing.Color.Black;
            this.btnIptal.Location = new System.Drawing.Point(181, 108);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(121, 33);
            this.btnIptal.TabIndex = 10;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(20, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 23);
            this.label14.TabIndex = 9;
            this.label14.Text = "Koltuk Numarası";
            // 
            // cmbKoltukIptal
            // 
            this.cmbKoltukIptal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKoltukIptal.FormattingEnabled = true;
            this.cmbKoltukIptal.Location = new System.Drawing.Point(20, 62);
            this.cmbKoltukIptal.Name = "cmbKoltukIptal";
            this.cmbKoltukIptal.Size = new System.Drawing.Size(282, 31);
            this.cmbKoltukIptal.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(7, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Film Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(7, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Film Adı";
            // 
            // btnSatis
            // 
            this.btnSatis.ForeColor = System.Drawing.Color.Black;
            this.btnSatis.Location = new System.Drawing.Point(146, 334);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(196, 46);
            this.btnSatis.TabIndex = 8;
            this.btnSatis.Text = "Satış Yap";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // txtKoltuk
            // 
            this.txtKoltuk.Enabled = false;
            this.txtKoltuk.Location = new System.Drawing.Point(146, 255);
            this.txtKoltuk.Name = "txtKoltuk";
            this.txtKoltuk.Size = new System.Drawing.Size(196, 30);
            this.txtKoltuk.TabIndex = 6;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(146, 222);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(196, 30);
            this.txtTelNo.TabIndex = 5;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(146, 189);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(196, 30);
            this.txtAdSoyad.TabIndex = 4;
            // 
            // cmbSalon
            // 
            this.cmbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(146, 87);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(196, 31);
            this.cmbSalon.TabIndex = 3;
            this.cmbSalon.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cmbFilmSeansi
            // 
            this.cmbFilmSeansi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmSeansi.FormattingEnabled = true;
            this.cmbFilmSeansi.Location = new System.Drawing.Point(146, 155);
            this.cmbFilmSeansi.Name = "cmbFilmSeansi";
            this.cmbFilmSeansi.Size = new System.Drawing.Size(196, 31);
            this.cmbFilmSeansi.TabIndex = 2;
            this.cmbFilmSeansi.SelectedIndexChanged += new System.EventHandler(this.cmbFilmSeansi_SelectedIndexChanged);
            // 
            // cmbFilmTarihi
            // 
            this.cmbFilmTarihi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmTarihi.FormattingEnabled = true;
            this.cmbFilmTarihi.Location = new System.Drawing.Point(146, 121);
            this.cmbFilmTarihi.Name = "cmbFilmTarihi";
            this.cmbFilmTarihi.Size = new System.Drawing.Size(196, 31);
            this.cmbFilmTarihi.TabIndex = 1;
            this.cmbFilmTarihi.SelectedIndexChanged += new System.EventHandler(this.cmbFilmTarihi_SelectedIndexChanged);
            // 
            // cmbFilmAdi
            // 
            this.cmbFilmAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmAdi.FormattingEnabled = true;
            this.cmbFilmAdi.Location = new System.Drawing.Point(146, 53);
            this.cmbFilmAdi.Name = "cmbFilmAdi";
            this.cmbFilmAdi.Size = new System.Drawing.Size(196, 31);
            this.cmbFilmAdi.TabIndex = 0;
            this.cmbFilmAdi.SelectedIndexChanged += new System.EventHandler(this.cmbFilmAdi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(529, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(757, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "   aa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(757, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "   aa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(834, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dolu Koltuk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(834, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Boş Koltuk";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Red;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(1160, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 354);
            this.label15.TabIndex = 15;
            this.label15.Text = "P\r\n\r\n\r\nE\r\n\r\n\r\nR\r\n\r\n\r\nD\r\n\r\n\r\nE";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblFilmOyuncular);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.lblFilmSure);
            this.groupBox3.Controls.Add(this.lblFilmYonetmen);
            this.groupBox3.Controls.Add(this.lblFilmVizyon);
            this.groupBox3.Controls.Add(this.lblFilmTuru);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.lblFilmAdi);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(425, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 627);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Film Bilgileri";
            // 
            // lblFilmOyuncular
            // 
            this.lblFilmOyuncular.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmOyuncular.Location = new System.Drawing.Point(31, 503);
            this.lblFilmOyuncular.Name = "lblFilmOyuncular";
            this.lblFilmOyuncular.Size = new System.Drawing.Size(229, 103);
            this.lblFilmOyuncular.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(31, 467);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 20);
            this.label20.TabIndex = 12;
            this.label20.Text = "Oyuncular:";
            // 
            // lblFilmSure
            // 
            this.lblFilmSure.AutoSize = true;
            this.lblFilmSure.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmSure.Location = new System.Drawing.Point(31, 440);
            this.lblFilmSure.Name = "lblFilmSure";
            this.lblFilmSure.Size = new System.Drawing.Size(44, 23);
            this.lblFilmSure.TabIndex = 11;
            this.lblFilmSure.Text = "Süre";
            // 
            // lblFilmYonetmen
            // 
            this.lblFilmYonetmen.AutoSize = true;
            this.lblFilmYonetmen.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmYonetmen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilmYonetmen.Location = new System.Drawing.Point(31, 413);
            this.lblFilmYonetmen.Name = "lblFilmYonetmen";
            this.lblFilmYonetmen.Size = new System.Drawing.Size(89, 23);
            this.lblFilmYonetmen.TabIndex = 10;
            this.lblFilmYonetmen.Text = "Yönetmen";
            // 
            // lblFilmVizyon
            // 
            this.lblFilmVizyon.AutoSize = true;
            this.lblFilmVizyon.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmVizyon.Location = new System.Drawing.Point(31, 384);
            this.lblFilmVizyon.Name = "lblFilmVizyon";
            this.lblFilmVizyon.Size = new System.Drawing.Size(106, 23);
            this.lblFilmVizyon.TabIndex = 9;
            this.lblFilmVizyon.Text = "Vizyon Tarihi";
            // 
            // lblFilmTuru
            // 
            this.lblFilmTuru.AutoSize = true;
            this.lblFilmTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmTuru.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFilmTuru.Location = new System.Drawing.Point(31, 345);
            this.lblFilmTuru.Name = "lblFilmTuru";
            this.lblFilmTuru.Size = new System.Drawing.Size(100, 28);
            this.lblFilmTuru.TabIndex = 8;
            this.lblFilmTuru.Text = "Film Türü";
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmAdi.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilmAdi.ForeColor = System.Drawing.Color.White;
            this.lblFilmAdi.Location = new System.Drawing.Point(31, 312);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(104, 33);
            this.lblFilmAdi.TabIndex = 7;
            this.lblFilmAdi.Text = "Film Adı";
            // 
            // btnSatislar
            // 
            this.btnSatislar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSatislar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatislar.ImageIndex = 7;
            this.btnSatislar.ImageList = this.ımageList1;
            this.btnSatislar.Location = new System.Drawing.Point(591, 11);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(121, 70);
            this.btnSatislar.TabIndex = 17;
            this.btnSatislar.Text = "Satışlar";
            this.btnSatislar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatislar.UseVisualStyleBackColor = true;
            this.btnSatislar.Click += new System.EventHandler(this.btnSatislar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1193, 727);
            this.Controls.Add(this.btnSatislar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSeansListele);
            this.Controls.Add(this.btnSeansEkle);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.btnSalonEkle);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.Button btnSeansListele;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKoltuk;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.ComboBox cmbFilmSeansi;
        private System.Windows.Forms.ComboBox cmbFilmTarihi;
        private System.Windows.Forms.ComboBox cmbFilmAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbKoltukIptal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblFilmOyuncular;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblFilmSure;
        private System.Windows.Forms.Label lblFilmYonetmen;
        private System.Windows.Forms.Label lblFilmVizyon;
        private System.Windows.Forms.Label lblFilmTuru;
        private System.Windows.Forms.Label lblFilmAdi;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnSatislar;
        private System.Windows.Forms.TextBox txtUcret;
    }
}

