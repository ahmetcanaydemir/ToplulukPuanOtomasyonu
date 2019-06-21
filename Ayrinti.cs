using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    enum Tip
    {
        Ekle, Guncelle
    }
    public partial class Ayrinti : Form
    {
        Tip tip;
        int uyeId;
        public Ayrinti()
        {
            InitializeComponent();
            tabControl1.Controls.Remove(tabPage2);
            this.Text = btnUyeEkle.Text = "Üye Ekle";
            tip = Tip.Ekle;
        }
        public Ayrinti(int uyeId,bool puanSekmesi)
        {
            InitializeComponent();
            
            this.Text=btnUyeEkle.Text = "Üye Güncelle";
            tip = Tip.Guncelle;

            this.uyeId = uyeId;
            if(puanSekmesi)
            {
                tabControl1.SelectedTab = tabPage2;
            }
            Doldur();
           
        }

        private void Ayrinti_Load(object sender, EventArgs e)
        {
            comboboxDoldur();
        }

        
        

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            if(tip == Tip.Ekle)
            {
                UyeEkle();
            }
            else
            {
                UyeGuncelle();
            }
            comboboxDoldur();
        }

        private void Doldur()
        {
            Veritabani vt = new Veritabani();
            DataTable dt = vt.DtVeriCek("SELECT * from uye where id="+uyeId);
            if (dt.Rows.Count == 0) return;
            var satir = dt.Rows[0];
            txtAd.Text = satir["ad"].ToString();
            txtSoyad.Text = satir["soyad"].ToString();
            txtTelefon.Text = satir["telefon"].ToString();
            txtMail.Text = satir["mail"].ToString();
            rchAdres.Text = satir["adres"].ToString();
            txtFakulte.Text = satir["fakulte"].ToString();
            txtBolum.Text = satir["bolum"].ToString();
            txtSinif.Text = satir["sinif"].ToString();
            cmbKomite.Text = satir["komite"].ToString();
            lstGorevler.Items.AddRange(satir["gorevler"].ToString().Split(','));
            rchEkstra.Text = satir["ozelAlan"].ToString();
            PuanDoldur();
        }

        private void comboboxDoldur()
        {
            cmbKomite.Items.Clear();
            cmbGorev.Items.Clear();
            Veritabani vt = new Veritabani();
            DataTable dt = vt.DtVeriCek("SELECT DISTINCT komite from uye");
            foreach(DataRow satir in dt.Rows)
            {
                cmbKomite.Items.Add(satir[0].ToString());
            }
            dt = vt.DtVeriCek("SELECT DISTINCT gorevler from uye");
            List<string> gorevler = new List<string>();
            foreach (DataRow satir in dt.Rows)
            {
                foreach(string eleman in satir[0].ToString().Split(','))
                {
                    if (gorevler.IndexOf(eleman) == -1)
                        gorevler.Add(eleman);
                }
            }
            cmbGorev.Items.AddRange(gorevler.ToArray());
        }

        private void PuanDoldur()
        {
            DataTable dt;
            dtgVeri.DataSource = dt = new Veritabani().DtVeriCek("SELECT id as Id,puan as Puan, aciklama as Açıklama, tarih as Tarih from puan WHERE uyeid=" + uyeId);
            int toplamPuan = 0;
            foreach(DataRow eleman in dt.Rows)
            {
                toplamPuan+= Convert.ToInt32(eleman["puan"]);
            }
            lblToplamPuan.Text = toplamPuan.ToString();
        }

        private void UyeEkle()
        {
            Veritabani vt = new Veritabani();
            List<string> gorevler = new List<string>();
            foreach(var eleman in lstGorevler.Items)
                gorevler.Add(eleman.ToString());
            vt.EkleSilGuncelle($"INSERT INTO uye (ad,soyad,telefon,mail,adres,fakulte,bolum,sinif,komite,gorevler,ozelAlan) VALUES('{txtAd.Text.Replace("'","''")}','{txtSoyad.Text.Replace("'", "''")}','{txtTelefon.Text.Replace("'", "''")}','{txtMail.Text.Replace("'", "''")}','{rchAdres.Text.Replace("'", "''")}','{txtFakulte.Text.Replace("'", "''")}','{txtBolum.Text.Replace("'", "''")}','{txtSinif.Text.Replace("'", "''")}','{cmbKomite.Text.Replace("'", "''")}','{string.Join(",", gorevler)}','{rchEkstra.Text.Replace("'", "''")}')");
            MessageBox.Show("Başarıyla eklendi!");
            temizle();
        }
        private void UyeGuncelle()
        {
            Veritabani vt = new Veritabani();
            List<string> gorevler = new List<string>();
            foreach (var eleman in lstGorevler.Items)
                gorevler.Add(eleman.ToString());
            vt.EkleSilGuncelle($"UPDATE uye SET ad='{txtAd.Text.Replace("'", "''")}',soyad='{txtSoyad.Text.Replace("'", "''")}',telefon='{txtTelefon.Text.Replace("'", "''")}',mail='{txtMail.Text.Replace("'", "''")}',adres='{rchAdres.Text.Replace("'", "''")}',fakulte='{txtFakulte.Text.Replace("'", "''")}',bolum='{txtBolum.Text.Replace("'", "''")}',sinif='{txtSinif.Text.Replace("'", "''")}',komite='{cmbKomite.Text.Replace("'", "''")}',gorevler='{string.Join(",", gorevler)}',ozelAlan='{rchEkstra.Text.Replace("'", "''")}' WHERE id="+uyeId);
            MessageBox.Show("Başarıyla güncellendi!");

        }
        private void temizle()
        {
            rchEkstra.Text= cmbGorev.Text= cmbKomite.Text= txtSinif.Text= txtBolum.Text= txtFakulte.Text= rchAdres.Text = txtMail.Text= txtTelefon.Text= txtSoyad.Text = txtAd.Text = string.Empty;
            lstGorevler.Items.Clear();
            txtAd.Focus();
        }

        private void btnPuanEkle_Click(object sender, EventArgs e)
        {
            Veritabani vt = new Veritabani();
            vt.EkleSilGuncelle($"INSERT INTO puan (uyeid,puan,aciklama,tarih) VALUES ({uyeId},{(int)nmPuan.Value},'{txtPuanAciklama.Text.Replace("'", "''")}','{DateTime.Today.ToString("yyyy-MM-dd")}')");
            MessageBox.Show((int)nmPuan.Value+" puan eklendi");
            PuanDoldur();
            txtPuanAciklama.Text = string.Empty;
            nmPuan.Value = 0;
        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            lstGorevler.Items.Add(cmbGorev.Text);
            cmbGorev.Text = string.Empty;
        }

        private void lstGorevler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstGorevler.SelectedItem != null)
            {
                lstGorevler.Items.Remove(lstGorevler.SelectedItem);
            }
        }
    }
}
