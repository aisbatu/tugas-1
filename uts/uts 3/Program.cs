using System;

namespace uts3
{
    class Program
    {
        static int nama;
        static int tahunlahir;
        static void Main(string[] args)
        {
            Console.Clear();
            string nama;
            Console.WriteLine("Nama     :"); nama = Console.ReadLine().ToUpper();
            int tahunlahir;
            Console.WriteLine("Tahun Kelahiran :"); tahunlahir = Convert.ToInt32(Console.ReadLine());

            printtiket(nama, tahunlahir);
            biayatiket(tahunlahir);
        }
        static int biayatiket(int tahunlahir)
        {
            int umur = 2021 - tahunlahir;
            int biaya = 0;
            if (umur < 10 || umur >60)
            {
                biaya = 10000;
            }
            else
            {
                biaya = 25000;
            }
            return biaya;
        }
        static void printtiket(string nama, int tahunlahir)
        {
            Console.WriteLine("|**************************|");
            Console.WriteLine("|      -- Studio 1 --      |");
            Console.WriteLine("|Nama  :  {0,17}|",nama);
            Console.WriteLine("|Harga :  Rp{0,15}|",biayatiket(tahunlahir));
            Console.WriteLine("|--------------------------|"); Console.ReadLine();
        }
    }
}