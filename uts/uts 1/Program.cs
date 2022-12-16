using System;

namespace uts
{
    class Program
    {
        static String nama;
        static String nim;
        static String konsentrasi;
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Nama        : "); nama = Console.ReadLine().ToUpper();
            Console.WriteLine("Nim         : "); nim = Console.ReadLine();
            Console.WriteLine("Konsentrasi : "); konsentrasi = Console.ReadLine().ToUpper();
            mahasiswabaru mhs = new mahasiswabaru(nama, nim, konsentrasi);
            mhs.printnametag();
        }
    }
    class mahasiswabaru
    {
        string nama;
        string nim;
        string konsentrasi;
        public mahasiswabaru(string Name, string NIM, string Konsentrasi)
        {
            nama = Name;
            nim = NIM;
            konsentrasi = Konsentrasi;
        }
        public void printnametag()
        {
            Console.WriteLine();
            Console.WriteLine("|***************************|");
            Console.WriteLine("|Nama : {0,20}|",nama);
            Console.WriteLine("|     : {0,20}|",nim);
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("|{0,27}|",konsentrasi);
            Console.WriteLine("|***************************|");
        }
    }
}