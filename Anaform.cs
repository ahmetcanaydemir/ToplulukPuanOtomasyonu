using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class ANAFORM : Form
    {
        public ANAFORM()
        {
            InitializeComponent();       
        }

        DataTable tablo;
        private void ANAFORM_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        private void Doldur()
        {
            dtgVeri.DataSource =tablo =  new Veritabani().DtVeriCek("SELECT uye.id as Id, ad as Ad, soyad as Soyad,komite as Komite, telefon as Telefon, fakulte as Fakülte, bolum as Bölüm, sinif as Sınıf, ifnull(sum(puan),0) as Puan  FROM uye LEFT JOIN puan on puan.uyeid = uye.id GROUP BY uye.id");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ayrinti ayrinti = new Ayrinti();
            ayrinti.ShowDialog();
            Doldur();
        }

        private void dtgVeri_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.RowIndex == -1) return;

            ContextMenuStrip baslikMenu = new ContextMenuStrip();
            var menuGuncelle = new ToolStripMenuItem("Görüntüle ve Güncelle");
            menuGuncelle.Click += MenuGuncelle_Click;
            var menuPuan = new ToolStripMenuItem("Puan Ekle");
            menuPuan.Click += MenuPuan_Click;
            var menuSil = new ToolStripMenuItem("Sil");
            menuSil.Click += MenuSil_Click;
            baslikMenu.Items.AddRange(new ToolStripItem[] { menuGuncelle,menuPuan,menuSil });

            baslikMenu.Show(Cursor.Position);

        }

        private void MenuSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgVeri.SelectedRows[0].Cells["Id"].Value);
            Veritabani vt = new Veritabani();
            vt.EkleSilGuncelle("DELETE FROM uye where id=" + id);
            vt.EkleSilGuncelle("DELETE FROM puan where uyeid=" + id);
            MessageBox.Show("Silindi!");
            Doldur();
        }

        private void MenuPuan_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgVeri.SelectedRows[0].Cells["Id"].Value);
            Ayrinti ayrinti = new Ayrinti(id,true);
            ayrinti.ShowDialog();
            Doldur();
        }

        private void MenuGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgVeri.SelectedRows[0].Cells["Id"].Value);
            Ayrinti ayrinti = new Ayrinti(id,false);
            ayrinti.ShowDialog();
            Doldur();
        }

        private void dtgVeri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int id = Convert.ToInt32(dtgVeri.SelectedRows[0].Cells["Id"].Value);
            Ayrinti ayrinti = new Ayrinti(id, false);
            ayrinti.ShowDialog();
            Doldur();
        }

        private string FiltreStringi(string aramaMetni, string sutunBasligi)
        {
            string filtre = string.Empty;
            filtre += $"CONVERT([{sutunBasligi}], System.String) Like '%{aramaMetni}%'";
            filtre += " OR ";
            return filtre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ara();
        }
        void Ara()
        {
            var filtre = new StringBuilder();
            foreach (DataGridViewColumn sutun in dtgVeri.Columns)
            {
                filtre.Append(FiltreStringi(txtAra.Text, sutun.HeaderText));
            }
            tablo.DefaultView.RowFilter = filtre.ToString().Substring(0, filtre.Length - 4);
        }

        private void txtAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Ara();
        }
    }

}
