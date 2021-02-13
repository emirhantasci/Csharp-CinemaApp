using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SinemaApplication
{
    public partial class Form6 : Form
    {
        sinemaTableAdapters.satisTableTableAdapter satisListesi = new sinemaTableAdapters.satisTableTableAdapter();
        public Form6()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 anaSayfa = new Form1();
            anaSayfa.Show();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satisListesi.tariheGoreListeleme2(dateTimePicker1.Text);
            ToplamUcretHesaplama();
        }

        private void ToplamUcretHesaplama()
        {
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells["ucret"].Value);
            }
            label2.Text = toplam.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string p = dateTimePicker1.Text;
            string[] parcalar = p.Split(' ');
            if (parcalar[0] == "1" || parcalar[0] == "2" || parcalar[0] == "3" || parcalar[0] == "4" || parcalar[0] == "5" || parcalar[0] == "6" || parcalar[0] == "7" || parcalar[0] == "8" || parcalar[0] == "9")
            {
                string yenis = "0" + p;
                dataGridView1.DataSource = satisListesi.tariheGoreListeleme2(yenis);
            }
            else
            {
                string yenis = p;
                dataGridView1.DataSource = satisListesi.tariheGoreListeleme2(yenis);
            }
            ToplamUcretHesaplama();
        }
    }
}
