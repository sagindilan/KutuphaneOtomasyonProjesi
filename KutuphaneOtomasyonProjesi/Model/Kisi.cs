using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonProjesi.Model
{
    public class Kisi
    {

        public string id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmatarihi { get; set; }
        public  string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }

        public Kisi()
        {
            
        }
        public Kisi(string id, string isim, string soyisim, DateTime olusturmatarihi,string kullaniciadi, string sifre, string yetki)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.olusturmatarihi = olusturmatarihi;
            this.kullaniciadi = kullaniciadi;
            this.sifre = sifre;
            this.yetki = yetki;
        }

        public void setId(string id)
        {
            this.id=id;
        }
        public string getId()
        {
            return this.id;
        }
        public void setIsim(string isim)
        { 
            this.isim = isim; 
        }
        public string getIsim()
        {
            return this.isim;
        }
        public void setSoyisim (string soyisim)
        {
            this.soyisim= soyisim;
        }
        public string getSoyisim()
        {
            return this.soyisim;
        }
        public void setOlusturmaTarihi(DateTime olusturmatarihi)
        {
            this.olusturmatarihi= olusturmatarihi;
        }
        public DateTime getOlusturmaTarihi()
        {
            return this.olusturmatarihi;
        }
        public void setKullaniciAdi(string kullaniciadi)
        {
            this.kullaniciadi = kullaniciadi;
        }
        public string getKullaniciAdi()
        {
            return this.kullaniciadi;
        }
        public void setSifre(string sifre)
        {
            this.sifre = sifre;
        }
        public string getSifre()
        {
            return this.sifre = sifre;
        }
        public void setYetki(string yetki)
        {
            this.yetki = yetki;
        }
        public string getYetki()
        {
            return this.yetki= yetki;
        }
    }
}
