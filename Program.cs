using System;


namespace TugasPertemuan4
{
    internal class Program
    {
        class program
        {

            static void Main(string[] args)
            {
                Mobil mobil1 = new Mobil();
                mobil1.Warna_Mobil = "Silver";
                mobil1.JumlahPintu_Mobil = 4;
                mobil1.Merek_Mobil = "Toyota";
                mobil1.Model_Mobil = "Rush TRD Sportivo";
                mobil1.TahunKeluaran_Mobil = 2016;

                mobil1.InfoMobil();
                mobil1.Gas(80); // Output: Mobil Rush TRD Sportivo berjalan dengan kecepatan 80
                mobil1.Klakson("Telolet"); // Output: Telolet
                mobil1.TampilanInfo(); // Output: Mobil saya berwarna Silver, merek Toyota model Rush TRD Sportivo keluaran tahun 2016 dengan jumlah pintu sebanyak 4
            }
        }

    }
}
