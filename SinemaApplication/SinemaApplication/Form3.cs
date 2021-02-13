using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SinemaApplication
{
    public partial class Form3 : Form
    {
        sinemaTableAdapters.salonTableTableAdapter salon = new sinemaTableAdapters.salonTableTableAdapter();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 anaSayfa = new Form1();
            anaSayfa.Show();
            this.Close();
        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                salon.salonEkle(txtSalonAdi.Text);
                MessageBox.Show("Salon eklendi!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Aynı salon zaten sistemde kayıtlı.");
                
            }
            txtSalonAdi.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
