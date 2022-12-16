using System;

namespace uts2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double kurs = 15354.80;
            int totalusd;
            Console.WriteLine("rate USD ke Rp : \n"+kurs);
            while(true)
            {
                try
                {
                    Console.WriteLine("Jumlah USD:");
                    totalusd = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("maaf! hanya menerima input berupa angka");
                    continue;
                }
            }
            Console.WriteLine("Hasil Konversi: "+(kurs*totalusd));
        }
    }
}