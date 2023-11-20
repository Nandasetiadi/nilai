using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama;
            double nilaiHarian, nilaiUTS, nilaiUAS, rataRata;
            char predikat;

            Console.WriteLine("Program Menghitung Nilai Rata-Rata dan Predikat");
            Console.WriteLine("===============================================");

            Console.Write("Masukkan Nama Anda : ");
            nama = Console.ReadLine();

            Console.Write("Masukkan Nilai Harian : ");
            nilaiHarian = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Nilai UTS : ");
            nilaiUTS = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Nilai UAS : ");
            nilaiUAS = Convert.ToDouble(Console.ReadLine());

            // Menghitung rata-rata
            rataRata = (nilaiHarian + nilaiUTS + nilaiUAS) / 3;

            // Menentukan predikat berdasarkan rata-rata
            if (rataRata >= 80)
            {
                predikat = 'A';
            }
            else if (rataRata >= 70)
            {
                predikat = 'B';
            }
            else if (rataRata >= 60)
            {
                predikat = 'C';
            }
            else if (rataRata >= 50)
            {
                predikat = 'D';
            }
            else
            {
                predikat = 'E';
            }

            Console.WriteLine("\n===============================================");
            Console.WriteLine("Nama             : " + nama);
            Console.WriteLine("Nilai Harian     : " + nilaiHarian);
            Console.WriteLine("Nilai UTS        : " + nilaiUTS);
            Console.WriteLine("Nilai UAS        : " + nilaiUAS);
            Console.WriteLine("Rata-Rata        : " + rataRata.ToString("0.##"));
            Console.WriteLine("Predikat Nilai   : " + predikat);

            Console.ReadKey();
        }
    }
}
