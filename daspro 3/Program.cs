using System;

namespace daspro_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 4;
            const int b = 6;
            const int c = 10;

            int hasiltambah = a+b+c;
            int hasilkali = a*b*c;
            int hasilkurang = a-b-c;
            int hasilbagi = a/b/c;


            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");       
            Console.WriteLine("- Password terdiri dari 4 angka");
            Console.WriteLine("- Jika ditambahkan hasilnya " + hasiltambah);
            Console.WriteLine("- Jika dikalikan hasilnya  " + hasilkali);
            Console.WriteLine("- Jika dikurangi hasilnya " + hasilkurang);
            Console.WriteLine("- Jika dibagi hasilnya " + hasilbagi);
            Console.WriteLine("");
            Console.WriteLine("Enter Code :");
            
     
        }   
    }
}
