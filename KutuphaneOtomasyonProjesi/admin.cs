using KutuphaneOtomasyonProjesi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonProjesi
{
    public partial class admin : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarim;
        public admin(List <Kisi>kisilerim, List <Kitap>kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

      

     
        public void verilerigetir()
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtisim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtullaniciad.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtyetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            verilerigetir();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            foreach( Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getSoyisim(), kisi.getOlusturmaTarihi(), kisi.getKullaniciAdi(), kisi.getSifre(), kisi.getYetki());

            }
            foreach(Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(), kitap.getKitapisim(), kitap.getyazar(), kitap.getdil(), kitap.getyayinevi(), kitap.gettur(), kitap.getadet(), kitap.getsayfa(), kitap.getyil());
            }
         
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtid.Text,txtisim.Text,txtsoyisim.Text,maskedTextBox1.Text,txtullaniciad.Text,txtsifre.Text,txtyetki.Text);
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        } 


    


        private void button5temizle_Click(object sender, EventArgs e)
        {
            txtid.Text= string.Empty;
            txtisim.Text= string.Empty;
            txtsoyisim.Text = string.Empty;
            maskedTextBox1.Text= string.Empty;
            txtullaniciad.Text= string.Empty;
            txtsifre.Text= string.Empty;
            txtyetki.Text= string.Empty;

        }    

        private void buttonekle(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txtkitapid.Text, txtkitapisim.Text,txtyazar.Text,txtdil.Text,txtyayinevi.Text,txttur.Text, txtadet.Text, txtsayfasayi.Text,
                txtyayinyili.Text);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int kitapid = Convert.ToInt32(txtkitapid.Text);
            string kitapisim = txtkitapisim.Text;
            string yazar = txtyazar.Text;
            string dil = txtdil.Text;
            string yayinevi = txtyayinevi.Text;
            string tur = txttur.Text;
            int adet = Convert.ToInt32(txtadet.Text);
            int sayfasayisi = Convert.ToInt32(txtsayfasayi.Text);
            int yayinyili = Convert.ToInt32(txtyayinyili.Text);

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid, kitapisim, yazar, dil, yayinevi,tur,adet,sayfasayisi, yayinyili);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtkitapisim.Text= dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtyazar.Text= dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtdil.Text= dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtyayinevi.Text= dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txttur.Text= dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txtadet.Text= dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txtsayfasayi.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txtyayinyili.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();



        }

        private void buttonguncelle_Click_1(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string isim = txtisim.Text;
            string soyisim = txtsoyisim.Text;
            string tarih = maskedTextBox1.Text;
            string kullanciad = txtullaniciad.Text;
            string sifre = txtsifre.Text;
            string yetki = txtyetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim, tarih, kullanciad, sifre, yetki);

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            for ( int i = 0; i < groupBox2.Controls.Count; i++ )
            {
                if (groupBox2.Controls[i] is TextBox)
                {
                    groupBox2.Controls[i].Text= string.Empty;
                }
            }
        }      

        private void buttonara_Click(object sender, EventArgs e)
        {
            Kisi hedefkisi = null;

            string  secilenid = textBox1.Text;

            foreach(Kisi kisi in kisilerim)
            {
                if (kisi.getId() == secilenid)
                {
                    hedefkisi= kisi;
                    break;
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkisi.getId(), hedefkisi.getIsim(), hedefkisi.getSoyisim(), hedefkisi.getOlusturmaTarihi(), hedefkisi.getKullaniciAdi(), hedefkisi.getSifre(), hedefkisi.getYetki());

        }

        private void buttonyenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            foreach(Kisi hedefkisi in kisilerim )
            {
                dataGridView1.Rows.Add(hedefkisi.getId(), hedefkisi.getIsim(), hedefkisi.getSoyisim(), hedefkisi.getOlusturmaTarihi(), hedefkisi.getKullaniciAdi(), hedefkisi.getSifre(), hedefkisi.getYetki());
            }
        }

        private void buttonara2_Click(object sender, EventArgs e)
        {
            Kitap hedefkitap = null;

            int secilenkitapid = Convert.ToInt32(textBox2.Text);

            foreach (Kitap kitap in kitaplarim )
            {
                if (kitap.getKitapId() == secilenkitapid )
                {
                    hedefkitap = kitap;
                    break;
                }

                dataGridView2.Rows.Clear();
                dataGridView2.Rows.Add(hedefkitap.getKitapId(), hedefkitap.getKitapisim(), hedefkitap.getyazar(), hedefkitap.getdil(), hedefkitap.getyayinevi(), hedefkitap.gettur(), hedefkitap.getsayfa(), hedefkitap.getadet(), hedefkitap.getyil());

            }
        }

        private void buttonyenile2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

            foreach(Kitap hedefkitap in kitaplarim )
            {
                dataGridView2.Rows.Add(hedefkitap.getKitapId(), hedefkitap.getKitapisim(), hedefkitap.getyazar(), hedefkitap.getdil(), hedefkitap.getyayinevi(), hedefkitap.gettur(), hedefkitap.getsayfa(), hedefkitap.getadet(), hedefkitap.getyil());
            }
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("ÇIKIŞ YAPILDI ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    
    }
}
