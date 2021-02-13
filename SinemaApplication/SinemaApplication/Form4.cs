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
    public partial class Form4 : Form
    {
        SqlConnection SQLBaglantisi = new SqlConnection("Data Source=.;Initial Catalog=SinemaApp;Integrated Security=True");
        string seans = "";
        sinemaTableAdapters.seansTableTableAdapter seansEkle = new sinemaTableAdapters.seansTableTableAdapter();
        public Form4()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 anaSayfa = new Form1();
            anaSayfa.Show();
            this.Close();
        }

        private void FilmveSalonlar(ComboBox combo, string sql, string sql2)
        {
            SQLBaglantisi.Open();
            SqlCommand komut = new SqlCommand(sql, SQLBaglantisi);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                combo.Items.Add(read[sql2].ToString());
            }
            SQLBaglantisi.Close();
        }

        private void ChechBoxButtonSelected()
        {
            if (chc10.Checked == true) seans = chc10.Text;
            if (chc11.Checked == true) seans = seans + chc11.Text + "/";
            if (chc12.Checked == true) seans = seans + chc12.Text + "/";
            if (chc13.Checked == true) seans = seans + chc13.Text + "/";
            if (chc14.Checked == true) seans = seans + chc14.Text + "/";
            if (chc15.Checked == true) seans = seans + chc15.Text + "/";
            if (chc16.Checked == true) seans = seans + chc16.Text + "/";
            if (chc17.Checked == true) seans = seans + chc17.Text + "/";
            if (chc18.Checked == true) seans = seans + chc18.Text + "/";
            if (chc19.Checked == true) seans = seans + chc19.Text + "/";
            if (chc20.Checked == true) seans = seans + chc20.Text + "/";
            if (chc21.Checked == true) seans = seans + chc21.Text + "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChechBoxButtonSelected();
            string[] seanslar = seans.Split('/');

            if (seans != "")
            {
                foreach(var yeniSeans in seanslar)
                {
                    if (yeniSeans!="")
                    {
                        seansEkle.seansEkle(comboBox1.Text, comboBox2.Text, dateTimePicker1.Text, yeniSeans);
                    }
                }
                MessageBox.Show("Seans ekleme işlemi başarılı!");
                this.Close();
                Form4 yeniac = new Form4();
                yeniac.Show();
            }
            else if (seans == "")
            {
                MessageBox.Show("Seans seçimini yapmadınız!");
            }
            comboBox1.Text = "";
            comboBox2.Text = "";
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            FilmveSalonlar(comboBox1, "select * from filmTable", "filmAdi");
            FilmveSalonlar(comboBox2, "select * from salonTable", "salonAd");
            foreach (Control item3 in groupBox2.Controls)
            {
                item3.Enabled = false;
            }
        }
        private void TarihKarsilastirmaSQL()
        {
            SQLBaglantisi.Open();
            SqlCommand komut = new SqlCommand("select * from seansTable where salonAdi='" + comboBox2.Text + "' and tarih='" + dateTimePicker1.Text + "'", SQLBaglantisi);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                foreach (Control item2 in groupBox2.Controls)
                {
                    if (read["seans"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
                }
            }
            SQLBaglantisi.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach(Control item3 in groupBox2.Controls)
            {
                item3.Enabled = true;
            }
            DateTime thisDay = DateTime.Now;
            string s = thisDay.ToString("dd MMMM yyyy dddd");
            DateTime thisDayy = DateTime.Parse(s);
            MessageBox.Show(s);
            string p = dateTimePicker1.Text;
            DateTime yeni = DateTime.Parse(p);
            if (yeni == thisDayy)
            {
                MessageBox.Show(DateTime.Now.ToShortTimeString());
                foreach(Control item in groupBox2.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
                TarihKarsilastirmaSQL();
            }
            else if (yeni > thisDay)
            {
                TarihKarsilastirmaSQL();
            }
            else if(yeni < thisDay)
            {
                MessageBox.Show("Geçmiş zaman için işlem yapılamaz");
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
