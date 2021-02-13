using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SinemaApplication
{
    public partial class Form2 : Form
    {
        //sinemaTableAdapters.filmTableTableAdapter film= new sinemaTableAdapters.filmTableTableAdapter();
        sinemaTableAdapters.filmTableTableAdapter filmm = new sinemaTableAdapters.filmTableTableAdapter();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 anaSayfa = new Form1();
            anaSayfa.Show();
            this.Close();
        }

        private void btnFilmiEkle_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string nows = now.ToString();
            try
            {
                
                filmm.filmEklee(txtFilmAdi2.Text, txtYonetmen.Text, cmbFilmTuru.Text, txtFilmSure.Text, dtmpTarih.Text, nows, richTextBox1.Text, pictureBox1.ImageLocation);
                MessageBox.Show("Film bilgileri sisteme eklendi!", "Kayıt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txtFilmAdi2.Text = "";
            txtFilmSure.Text = "";
            txtYonetmen.Text = "";
            cmbFilmTuru.Text = "";

        }

        private void btnAfisSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
