using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Otel_Uygulamasi.Classlar
{
    public class Kullanici
    {
        public static string KullaniciAdi { get; set; }
        public static string isim { get; set; }
        public static string soyisim { get; set; }

        public static string OnayFormlari { get; set; } //Form çıkışlarında onay
        public static string BilgilendirmeFormlari { get; set; } //Ekleme - güncelleme işlemlerinde bilgilendirme yazısı

        public static string otoGeceModu { get; set; } //otomatik gece modu olsun mu olmasın mı 
        public static string klavye { get; set; } //form altında klavye aç / kapat visible

        public static string tileItemRenk { get; set; }
        public static string yetki { get; set; }

        public static string Gizli()
        {
            return "EGE";
        }

        public static void BilgiGuncelle()
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select personelAdi,personelKullaniciAdi,personelSoyadi,onayFormlari,bilgilendirmeFormlari,otoGeceModu,klavyeButonu,tileItemColor from Personel where personelKullaniciAdi = '" + Kullanici.KullaniciAdi + "'";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                Kullanici.isim = Dr["personelAdi"].ToString();
                Kullanici.KullaniciAdi = Dr["personelKullaniciAdi"].ToString();
                Kullanici.soyisim = Dr["personelSoyadi"].ToString();
                Kullanici.OnayFormlari = Dr["onayFormlari"].ToString();
                Kullanici.BilgilendirmeFormlari = Dr["bilgilendirmeFormlari"].ToString();
                Kullanici.otoGeceModu = Dr["otoGeceModu"].ToString(); // Form içerisinde değerlendirilecek
                Kullanici.klavye = Dr["klavyeButonu"].ToString();
                Kullanici.tileItemRenk = Dr["tileItemColor"].ToString();
            }
            connection.Close();
        }
    }
}
