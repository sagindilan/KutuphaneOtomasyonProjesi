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
    public partial class Form1 : Form
    {

        List<Kisi> kisilerim = new List<Kisi>();
        List <Kitap> kitaplarim = new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            textBoxkullaniciadi.Text = string.Empty;
            textBoxsifre.Text = string.Empty;
        }

        private void buttongiris_Click(object sender, EventArgs e)
        {
            string kullanici = textBoxkullaniciadi.Text;
            string sifre = textBoxsifre.Text;   

            bool kontrol = false;

            foreach(Kisi kisi in kisilerim )
            {
                if (kullanici.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.yetki == "admin")
                {
                    // admin sayfasına yönlendir...

                   
                    admin Admin = new admin(kisilerim, kitaplarim);

                    Admin.Show();
                    this.Hide();
                    kontrol = true;
                    break;



                }
                else if (kullanici.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.yetki == "üye")
                {
                    // üye sayfasına yönlendir...
                    uye uye = new uye(kitaplarim);
                    uye.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
            }
            if (!kontrol)
            {
                MessageBox.Show("HATALI GİRİŞ","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi("1","Dilan","Sagin",DateTime.Now,"sgndilan","1","admin"));
            kisilerim.Add(new Kisi("2", "a", "b", DateTime.Now, "a", "2", "üye"));
            kisilerim.Add(new Kisi("3", "x", "y", DateTime.Now, "x", "3", "üye"));
            kisilerim.Add(new Kisi("4", "m", "n", DateTime.Now, "m", "4", "üye"));

            kitaplarim.Add(new Kitap(1, "İçimizdeki Şeytan", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 100, 250, 2016));
            kitaplarim.Add(new Kitap(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "Roman", 350, 760, 2015));
            kitaplarim.Add(new Kitap(3, "Uçurtma Avcısı", "Khaled Hosseini", "İngilizce", "Everest Yayıncılık", "Roman", 100, 350, 2010));
            kitaplarim.Add(new Kitap(4, "Küçük Prens", "Antoine de Saint-Exupery", "İngilizce", "Can Çocuk Yayınları", "Roman", 50, 60, 2018));
            kitaplarim.Add(new Kitap(5, "Kürk Mantolu Madonna", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 650, 220, 2015));


        }

       
    }
}
