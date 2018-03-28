using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace Otel_Uygulamasi.Classlar
{
    public class Ardunio
    {
        public static bool ArdunioAktif { get; set; }
        public static string Port { get; set; }
        public static int Sicaklik1 { get; set; } //Array haline getir
        public static void Sicaklik1GuncelleVeriTabani()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = "update Havuzlarset havuzSicaklik="+Sicaklik1+"where havuzAdi='Havuz1'";
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static void ArdunioBaglantiBilgierliGuncelle()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = "update Ardunio Aktif= 1 and Port='" + Port + "' where ArdunioCinsi='SıcaklıkHavuz1'";
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static void Sicaklik1CihazdanOku()
        {
            SerialPort sp = new SerialPort();
            sp.PortName = Port;
            sp.Encoding = Encoding.ASCII;
            sp.BaudRate = 9600;
            sp.DataBits = 8;
            sp.StopBits = StopBits.One;
            sp.Parity = Parity.None;
            sp.ReadBufferSize = 4096;
            sp.NewLine = "\r\n";
            sp.Handshake = Handshake.None;
            sp.ReceivedBytesThreshold = 100000;
            Sicaklik1 = Convert.ToInt32(sp.ReadLine());
        }
    }
}
