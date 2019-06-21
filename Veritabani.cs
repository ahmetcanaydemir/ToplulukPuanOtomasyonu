using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Veritabani
    {
        private SQLiteCommand SorguyuKomutaCevir(string sorgu)
        {
            SQLiteCommand komut = new SQLiteConnection("Data Source="+Application.StartupPath+"\\Veri\\vt.db;Version=3;New=False;Compress=True;UTF8Encoding=True;DateTimeFormat=CurrentCulture").CreateCommand();
            komut.CommandText = sorgu;
            return komut;
        }
        public int EkleSilGuncelle(string sorgu)
        {
            try
            {
                SQLiteCommand komut = SorguyuKomutaCevir(sorgu);
                komut.Connection.Open();

                var sonuc = komut.ExecuteNonQuery();
                komut.Connection.Close();
                komut.Connection.Dispose();
                komut.Dispose();

                return sonuc;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public DataTable DtVeriCek(string sorgu)
        {
            DataTable dt = new DataTable();
            SQLiteCommand komut = SorguyuKomutaCevir(sorgu);
            komut.Connection.Open();
            var dr = komut.ExecuteReader(CommandBehavior.CloseConnection);
            dt.Load(dr);
            return dt;
        }
    }
}
