using System;

namespace TugasPertemuan4
{
    public class Mobil
    {
        // private fields
        private string warna_Mobil;
        private int jumlahPintu_Mobil;
        private string merek_Mobil;
        private string model_Mobil;
        private int tahunKeluaran_Mobil;

        // public properties
        public string Warna_Mobil
        {
            get { return warna_Mobil; }
            set { warna_Mobil = value; }
        }

        public int JumlahPintu_Mobil
        {
            get { return jumlahPintu_Mobil; }
            set { jumlahPintu_Mobil = value; }
        }

        public string Merek_Mobil
        {
            get { return merek_Mobil; }
            set { merek_Mobil = value; }
        }

        public string Model_Mobil
        {
            get { return model_Mobil; }
            set { model_Mobil = value; }
        }

        public int TahunKeluaran_Mobil
        {
            get { return tahunKeluaran_Mobil; }
            set { tahunKeluaran_Mobil = value; }
        }

        // public methods
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

