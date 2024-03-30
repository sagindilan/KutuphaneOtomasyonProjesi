using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonProjesi.Model
{
    public class Kitap
    {
        public int kitapid { get; set; }
        public string kitapismi { get; set; }
        public string kitapyazar { get; set; }
        public string kitapdili { get; set; }
        public string yayinevi { get; set; }
        public string tur { get; set; }
        public int adet  { get; set; }
        public int sayfasayisi { get; set; }
        public int basimyili { get; set; }

        public Kitap()
        {
                
        }

        public Kitap(int kitapid,string kitapisimi, string kitapyazar,string kitapdili,string yayinevi,string tur, int adet,int sayfasayisi , int basimyili)
        {
            this.kitapid = kitapid;
            this.kitapismi = kitapisimi;
            this.kitapyazar = kitapyazar;
            this.kitapdili = kitapdili;
            this.yayinevi = yayinevi;
            this.tur = tur;
            this.adet = adet;
            this.sayfasayisi = sayfasayisi;
            this.basimyili = basimyili; 
                           
        }
        public int getKitapId()
        {
            return this.kitapid;
        }
        public string getKitapisim()
        {
            return this.kitapismi;
        }
        public string getyazar()
        {
            return this.kitapyazar;
        }
        public string getdil()
        {
            return this.kitapdili;
        }
        public string getyayinevi()
        {
            return this.yayinevi;
        }
        public string gettur()
        {
            return this.tur;
        }
        public int getadet()
        {
            return this.adet;
        }
        public int getsayfa()
        {
            return this.sayfasayisi;
        }
        public int getyil()
        {
            return this.basimyili;
        }
            

    }
}
