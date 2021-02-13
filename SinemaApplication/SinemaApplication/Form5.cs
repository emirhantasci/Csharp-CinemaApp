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
    public partial class Form5 : Form
    {
        SqlConnection SQLBaglantisi = new SqlConnection("Data Source=.;Initial Catalog=SinemaApp;Integrated Security=True");
        DataTable tablo = new DataTable();
        public Form5()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 anaSayfa = new Form1();
            anaSayfa.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 seansEkle = new Form4();
            seansEkle.Show();
            this.Close();
        }

        private void seansListesi(string sorgu)
        {
            SQLBaglantisi.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, SQLBaglantisi);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.ForeColor = Color.Black;
            SQLBaglantisi.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            seansListesi("select * from seansTable where tarih like '" + dateTimePicker1.Text + "'");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            seansListesi("select * from seansTable where tarih like '" + dateTimePicker1.Text + "'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            seansListesi("select * from seansTable");
        }
    }
}
