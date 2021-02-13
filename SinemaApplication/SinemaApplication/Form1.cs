using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SinemaApplication
{
    public partial class Form1 : Form
    {
        SqlConnection SQLBaglantisi = new SqlConnection("Data Source=.;Initial Catalog=SinemaApp;Integrated Security=True");
        sinemaTableAdapters.satisTableTableAdapter satis = new sinemaTableAdapters.satisTableTableAdapter();

        int sayac = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            renklendirme();
            tarihler();
        }

        public void SalonveFilmler(ComboBox combo, string sql1, string sql2)
        {
            SQLBaglantisi.Open();
            SqlCommand komut = new SqlCommand(sql1, SQLBaglantisi);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());
            }
            SQLBaglantisi.Close();
        }

        

        private void filmAfisiGoster()
        {
            SQLBaglantisi.Open();
            SqlCommand komut = new SqlCommand("select * from filmTable where filmAdi='"+cmbFilmAdi.SelectedItem+"'", SQLBaglantisi);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                pictureBox1.ImageLocation = read["afis"].ToString();
                lblFilmAdi.Text = cmbFilmAdi.SelectedItem.ToString();
                lblFilmOyuncular.Text = read["oyuncular"].ToString();
                lblFilmSure.Text = read["filmSure"].ToString();
                lblFilmTuru.Text = read["fimTur"].ToString();
                lblFilmVizyon.Text = read["filmVizyonTarihi"].ToString();
                lblFilmYonetmen.Text = read["yonetmen"].ToString();
            }
            SQLBaglantisi.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BosKoltuklar();
            SalonveFilmler(cmbFilmAdi, "select * from filmTable", "filmAdi");
            SalonveFilmler(cmbSalon, "select * from salonTable", "salonAd");
        }

        private void BosKoltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    Button btn = new Button();
                    btn.Size = new Size(35, 35);
                    btn.BackColor = Color.White;
                    btn.Font = new Font(btn.Font.FontFamily, 8);
                    btn.Location = new Point(j * 40 + 30, i * 40 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 5 || i == 4)
                    {
                        Label lbl3 = new Label();
                        lbl3.BackColor = Color.Green;
                        lbl3.ForeColor = Color.White;
                        lbl3.TextAlign = ContentAlignment.TopCenter;
                        lbl3.Size = new Size(26, 25);
                        lbl3.Font = new Font(btn.Font.FontFamily, 11);
                        lbl3.Location = new Point(6 * 39, 22);
                        lbl3.Name = "↓";
                        lbl3.Text = "↓";
                        this.panel1.Controls.Add(lbl3);
                        Label lbl2 = new Label();
                        lbl2.BackColor = Color.White;
                        lbl2.ForeColor = Color.Black;
                        lbl2.TextAlign = ContentAlignment.BottomCenter;
                        lbl2.AutoSize = false;
                        lbl2.Size = new Size(26, 319);
                        lbl2.Font = new Font(btn.Font.FontFamily, 14);
                        lbl2.Location = new Point(6 * 39, 30);
                        lbl2.Name = "Gecis";
                        lbl2.Text = "Geçişş";
                        this.panel1.Controls.Add(lbl2);
                        Label lbl = new Label();
                        lbl.BackColor = Color.White;
                        lbl.ForeColor = Color.Black;
                        lbl.TextAlign = ContentAlignment.MiddleLeft;
                        lbl.Size = new Size(360, 27);
                        lbl.Font = new Font(btn.Font.FontFamily, 11);
                        lbl.Location = new Point(30, 5 * 39);
                        lbl.Name = "Gecis";
                        lbl.Text = "Geçiş";
                        this.panel1.Controls.Add(lbl);

                        continue;
                    }
                    sayac = sayac + 1;
                    this.panel1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void cmbDoluKoltuklar()
        {
            cmbKoltukIptal.Items.Clear();
            cmbKoltukIptal.Text = "";
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor==Color.Red)
                    {
                        cmbKoltukIptal.Items.Add(item.Text);
                    }
                }
            }
        }

        private void DoluKoltuklar()
        {
            SQLBaglantisi.Open();
            SqlCommand komut = new SqlCommand("select * from satisTable where filmAdi='"+cmbFilmAdi.SelectedItem+"' and salonAdi='"+cmbSalon.SelectedItem+"' and filmTarih='"+cmbFilmTarihi.SelectedItem+"' and saat='"+cmbFilmSeansi.SelectedItem+"'", SQLBaglantisi);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        if (read["koltukNo"].ToString()==item.Text)
                        {
                            item.BackColor = Color.Red;
                            
                        }
                    }
                }
            }
            SQLBaglantisi.Close();
        }

        private void renklendirme()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.White)
            {
                txtKoltuk.Text = b.Text;
                
            }
        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            Form3 salonEkle = new Form3();
            salonEkle.Show();
            this.Hide();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            Form2 filmEke = new Form2();
            filmEke.Show();
            this.Hide();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            Form4 seansEkle = new Form4();
            seansEkle.Show();
            this.Hide();
        }

        private void btnSeansListele_Click(object sender, EventArgs e)
        {
            Form5 seansListele = new Form5();
            seansListele.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            Form6 satislar = new Form6();
            satislar.Show();
            this.Hide();
        }

        private void cmbFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            renklendirme();
            txtAdSoyad.Text = "";
            txtKoltuk.Text = "";
            txtTelNo.Text = "";
            txtUcret.Text = "";
            cmbFilmSeansi.Text = "";

            filmAfisiGoster();
            
            DoluKoltuklar();
        }

        private void tarihler()
        {
            cmbFilmTarihi.Text = "";
            cmbFilmSeansi.Text = "";
            cmbFilmTarihi.Items.Clear();
            cmbFilmSeansi.Items.Clear();
            SQLBaglantisi.Open();
            SqlCommand komut = new SqlCommand("select * from seansTable where filmAdi='" + cmbFilmAdi.SelectedItem + "' and salonAdi='" + cmbSalon.SelectedItem+ "'", SQLBaglantisi);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString())>=DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!cmbFilmTarihi.Items.Contains(read["tarih"].ToString()))
                    {
                        cmbFilmTarihi.Items.Add(read["tarih"].ToString());
                    }
                }
            }
            SQLBaglantisi.Close();
        }

        private void seanslar()
        {
            cmbFilmSeansi.Text = "";
            cmbFilmSeansi.Items.Clear();
            SQLBaglantisi.Open();
            SqlCommand komut = new SqlCommand("select * from seansTable where filmAdi='" + cmbFilmAdi.SelectedItem + "' and salonAdi='" + cmbSalon.SelectedItem + "' and tarih='"+cmbFilmTarihi.SelectedItem+"'", SQLBaglantisi);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {

                    DateTime eski = DateTime.Parse(read["seans"].ToString());
                    DateTime yeni = DateTime.Parse(DateTime.Now.ToString("HH:mm:ss"));
                    if (eski >  yeni)
                    {
                        cmbFilmSeansi.Items.Add(read["seans"].ToString());
                    }
                     
                }
                else if (DateTime.Parse(read["tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    cmbFilmSeansi.Items.Add(read["seans"].ToString());
                }
            }
            SQLBaglantisi.Close();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            if (txtKoltuk.Text!="")
            {
                try
                {
                    satis.SatisYap(txtKoltuk.Text, cmbSalon.Text, cmbFilmAdi.Text, cmbFilmTarihi.Text, cmbFilmSeansi.Text, txtAdSoyad.Text, txtTelNo.Text, txtUcret.Text, DateTime.Now.ToString("dd MMMM yyyy dddd"));
                    MessageBox.Show("Satış yapıldı!", "Satış");
                    cmbFilmSeansi.Text = "";
                    txtAdSoyad.Text = "";
                    txtKoltuk.Text = "";
                    txtTelNo.Text = "";
                    txtUcret.Text = "";
                    
                    renklendirme();
                    
                }
                catch (Exception hata)
                {

                    MessageBox.Show("Hata oluştu! "+ hata, "Uyarı");
                } 
            }
            else
            {
                MessageBox.Show("Hata oluştu!\n  Koltuk seçimi yapmadınız.", "Uyarı");
            }
        }

        private void cmbFilmTarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            renklendirme();
            seanslar();
        }

        private void cmbFilmSeansi_SelectedIndexChanged(object sender, EventArgs e)
        {
            renklendirme();
            DoluKoltuklar();
            cmbDoluKoltuklar();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            SQLBaglantisi.Open();
            SqlCommand komut = new SqlCommand("delete from satisTable where koltukNo='"+ cmbKoltukIptal.Text.ToString() + "'", SQLBaglantisi);
            komut.ExecuteNonQuery();
            SQLBaglantisi.Close();
            MessageBox.Show("Bilet iptal edildi!", "İptal");
            renklendirme();
            DoluKoltuklar();
        }
    }
}
