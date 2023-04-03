using System;


namespace TugasPertemuan3
{
    public class Mobil
    {

        // property
        public string Warna_Mobil { get; set; }
        public int JumlahPintu_Mobil { get; set; }
        public string Merek_Mobil { get; set; }
        public string Model_Mobil { get; set; }
        public int TahunKeluaran_Mobil { get; set; }

        // method
        public void InfoMobil()
        {
            Console.WriteLine("Warna          : {0}", Warna_Mobil);
            Console.WriteLine("Jumlah Pintu   : {0}", JumlahPintu_Mobil);
            Console.WriteLine("Merek          : {0}", Merek_Mobil);
            Console.WriteLine("Model          : {0}", Model_Mobil);
            Console.WriteLine("Tahun Keluaran : {0}", TahunKeluaran_Mobil);

        }

        public void Gas(int Kecepatan)
        {
            Console.WriteLine("\nMobil " + Model_Mobil + " berjalan dengan kecepatan " + Kecepatan + "\n");
        }

        public void Klakson(string Suara)
        {
            Console.WriteLine("{0}\n", Suara);
        }

        public void TampilanInfo()
        {
            Console.WriteLine("Mobil saya berwarna " + Warna_Mobil + ", merek " + Merek_Mobil + ", model " + Model_Mobil + " keluaran tahun " + TahunKeluaran_Mobil + " dengan jumlah pintu sebanyak " + JumlahPintu_Mobil + "");
        }
    }
}
