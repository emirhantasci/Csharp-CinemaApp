
namespace SinemaApplication
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chc21 = new System.Windows.Forms.CheckBox();
            this.chc18 = new System.Windows.Forms.CheckBox();
            this.chc15 = new System.Windows.Forms.CheckBox();
            this.chc12 = new System.Windows.Forms.CheckBox();
            this.chc20 = new System.Windows.Forms.CheckBox();
            this.chc17 = new System.Windows.Forms.CheckBox();
            this.chc14 = new System.Windows.Forms.CheckBox();
            this.chc11 = new System.Windows.Forms.CheckBox();
            this.chc19 = new System.Windows.Forms.CheckBox();
            this.chc16 = new System.Windows.Forms.CheckBox();
            this.chc13 = new System.Windows.Forms.CheckBox();
            this.chc10 = new System.Windows.Forms.CheckBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seans Ekle";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(355, 27);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(160, 111);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(355, 28);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(355, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(24, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(491, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Seansları Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chc21);
            this.groupBox2.Controls.Add(this.chc18);
            this.groupBox2.Controls.Add(this.chc15);
            this.groupBox2.Controls.Add(this.chc12);
            this.groupBox2.Controls.Add(this.chc20);
            this.groupBox2.Controls.Add(this.chc17);
            this.groupBox2.Controls.Add(this.chc14);
            this.groupBox2.Controls.Add(this.chc11);
            this.groupBox2.Controls.Add(this.chc19);
            this.groupBox2.Controls.Add(this.chc16);
            this.groupBox2.Controls.Add(this.chc13);
            this.groupBox2.Controls.Add(this.chc10);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(24, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seanslar";
            // 
            // chc21
            // 
            this.chc21.AutoSize = true;
            this.chc21.Location = new System.Drawing.Point(346, 125);
            this.chc21.Name = "chc21";
            this.chc21.Size = new System.Drawing.Size(66, 24);
            this.chc21.TabIndex = 11;
            this.chc21.Text = "21:00";
            this.chc21.UseVisualStyleBackColor = true;
            // 
            // chc18
            // 
            this.chc18.AutoSize = true;
            this.chc18.Location = new System.Drawing.Point(346, 95);
            this.chc18.Name = "chc18";
            this.chc18.Size = new System.Drawing.Size(66, 24);
            this.chc18.TabIndex = 10;
            this.chc18.Text = "18:00";
            this.chc18.UseVisualStyleBackColor = true;
            // 
            // chc15
            // 
            this.chc15.AutoSize = true;
            this.chc15.Location = new System.Drawing.Point(346, 65);
            this.chc15.Name = "chc15";
            this.chc15.Size = new System.Drawing.Size(66, 24);
            this.chc15.TabIndex = 9;
            this.chc15.Text = "15:00";
            this.chc15.UseVisualStyleBackColor = true;
            // 
            // chc12
            // 
            this.chc12.AutoSize = true;
            this.chc12.Location = new System.Drawing.Point(346, 35);
            this.chc12.Name = "chc12";
            this.chc12.Size = new System.Drawing.Size(66, 24);
            this.chc12.TabIndex = 8;
            this.chc12.Text = "12:00";
            this.chc12.UseVisualStyleBackColor = true;
            // 
            // chc20
            // 
            this.chc20.AutoSize = true;
            this.chc20.Location = new System.Drawing.Point(183, 125);
            this.chc20.Name = "chc20";
            this.chc20.Size = new System.Drawing.Size(66, 24);
            this.chc20.TabIndex = 7;
            this.chc20.Text = "20:00";
            this.chc20.UseVisualStyleBackColor = true;
            // 
            // chc17
            // 
            this.chc17.AutoSize = true;
            this.chc17.Location = new System.Drawing.Point(183, 95);
            this.chc17.Name = "chc17";
            this.chc17.Size = new System.Drawing.Size(66, 24);
            this.chc17.TabIndex = 6;
            this.chc17.Text = "17:00";
            this.chc17.UseVisualStyleBackColor = true;
            // 
            // chc14
            // 
            this.chc14.AutoSize = true;
            this.chc14.Location = new System.Drawing.Point(183, 65);
            this.chc14.Name = "chc14";
            this.chc14.Size = new System.Drawing.Size(66, 24);
            this.chc14.TabIndex = 5;
            this.chc14.Text = "14:00";
            this.chc14.UseVisualStyleBackColor = true;
            // 
            // chc11
            // 
            this.chc11.AutoSize = true;
            this.chc11.Location = new System.Drawing.Point(183, 35);
            this.chc11.Name = "chc11";
            this.chc11.Size = new System.Drawing.Size(66, 24);
            this.chc11.TabIndex = 4;
            this.chc11.Text = "11:00";
            this.chc11.UseVisualStyleBackColor = true;
            // 
            // chc19
            // 
            this.chc19.AutoSize = true;
            this.chc19.Location = new System.Drawing.Point(26, 125);
            this.chc19.Name = "chc19";
            this.chc19.Size = new System.Drawing.Size(66, 24);
            this.chc19.TabIndex = 3;
            this.chc19.Text = "19:00";
            this.chc19.UseVisualStyleBackColor = true;
            // 
            // chc16
            // 
            this.chc16.AutoSize = true;
            this.chc16.Location = new System.Drawing.Point(26, 95);
            this.chc16.Name = "chc16";
            this.chc16.Size = new System.Drawing.Size(66, 24);
            this.chc16.TabIndex = 2;
            this.chc16.Text = "16:00";
            this.chc16.UseVisualStyleBackColor = true;
            // 
            // chc13
            // 
            this.chc13.AutoSize = true;
            this.chc13.Location = new System.Drawing.Point(26, 65);
            this.chc13.Name = "chc13";
            this.chc13.Size = new System.Drawing.Size(66, 24);
            this.chc13.TabIndex = 1;
            this.chc13.Text = "13:00";
            this.chc13.UseVisualStyleBackColor = true;
            // 
            // chc10
            // 
            this.chc10.AutoSize = true;
            this.chc10.Location = new System.Drawing.Point(26, 35);
            this.chc10.Name = "chc10";
            this.chc10.Size = new System.Drawing.Size(66, 24);
            this.chc10.TabIndex = 0;
            this.chc10.Text = "10:00";
            this.chc10.UseVisualStyleBackColor = true;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 400);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(94, 29);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(560, 444);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Seans Ekle";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chc21;
        private System.Windows.Forms.CheckBox chc18;
        private System.Windows.Forms.CheckBox chc15;
        private System.Windows.Forms.CheckBox chc12;
        private System.Windows.Forms.CheckBox chc20;
        private System.Windows.Forms.CheckBox chc17;
        private System.Windows.Forms.CheckBox chc14;
        private System.Windows.Forms.CheckBox chc11;
        private System.Windows.Forms.CheckBox chc19;
        private System.Windows.Forms.CheckBox chc16;
        private System.Windows.Forms.CheckBox chc13;
        private System.Windows.Forms.CheckBox chc10;
        private System.Windows.Forms.Button btnGeri;
    }
}