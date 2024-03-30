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
    public partial class uye : Form
    {
        List<Kitap> kitaplarim;

        public uye(List<Kitap>kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }
        private void btnara_Click(object sender, EventArgs e)
        {
            Kitap hedefkitap = null;

            int secilenkitap = Convert.ToInt32(textBox1.Text);

            foreach (Kitap kitap in kitaplarim )
            {
                if (kitap.getKitapId() == secilenkitap)
                {
                    hedefkitap = kitap;
                    break;
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkitap.getKitapId(), hedefkitap.getKitapisim(), hedefkitap.getyazar(), hedefkitap.getdil(), hedefkitap.getyayinevi(), hedefkitap.gettur(), hedefkitap.getadet(), hedefkitap.getsayfa(), hedefkitap.getyil());

        }

        private void uye_Load(object sender, EventArgs e)
        {
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView1.Rows.Add(kitap.getKitapId(),kitap.getKitapisim(),kitap.getyazar(),kitap.getdil(),kitap.getyayinevi(),kitap.gettur(),kitap.getadet(),kitap.getsayfa(),kitap.getyil() );
            }
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach( Kitap kitap in kitaplarim)
            {
                dataGridView1.Rows.Add(kitap.getKitapId(), kitap.getKitapisim(), kitap.getyazar(), kitap.getdil(), kitap.getyayinevi(), kitap.gettur(), kitap.getadet(), kitap.getsayfa(), kitap.getyil());
            }
        }
    }
}
