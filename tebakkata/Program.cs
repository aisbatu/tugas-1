using System;
using System.Collections.Generic;
namespace tebakkata
{
    class program
    {
        static int kesempatan = 5;
        static String katamisteri = "zaqki hidayat";
        static List<string> listtebakan = new List<String>{};
        
        static void Main(string[] args)
        {
            intro();
            mulaimain();
            selesai();
        }

        static bool cekjawaban(string katarahasia, List<string> list)
        {
            bool status = false;
            for (int i = 0; i < katarahasia.Length; i++)
            {
                string c = Convert.ToString(katarahasia[i]);
                if(list.Contains(c))
                {
                    status = true;
                } else
                {
                    return status = false;
                }
            }
            return status;
        }
        
        static string cekhuruf(string katarahasia, List<string> list)
        {
            string X = "";

            for (int i = 0; i < katarahasia.Length;i++)
            {
                string c = Convert.ToString(katarahasia[i]);
                if(list.Contains(c))
                {
                    X = X + c;
                } else
                {
                    X = X +"_";
                } 
            }
            return X;
        }
       
        static void intro()
        {
            Console.WriteLine("selamat datang, ayo bermain tebak kata");
            Console.WriteLine($"kamu punya {kesempatan} kesempatan untuk menebak kata misteri hari ini");
            Console.WriteLine("cluenya adalah, kata ini merupakan nama anggota kelas ini");
            Console.WriteLine("tebakan kali ini terdiri dari 2 kata");
            Console.WriteLine($"kata ini terdiri dari {katamisteri.Length} huruf");
            Console.WriteLine("siapakah yang dimaksud?\npencet enter untuk memulai");
            Console.ReadKey();
            Console.Clear();
        }
        static void mulaimain()
        {
            while(kesempatan>0)
            {
                Console.Write("apa huruf tebakanmu? (pilih a-z) : ");
                String input = Console.ReadLine();
                listtebakan.Add(input);
                if(cekjawaban(katamisteri, listtebakan))
                {
                    Console.Clear();
                    Console.WriteLine("selamat! anda berhasil");
                    Console.WriteLine($"kata misteri hari ini adalah {katamisteri}");
                    break;
                } else if(katamisteri.Contains(input))
                {
                    Console.WriteLine("huruf itu berada di kata ini");
                    Console.WriteLine("sekarang tebak huruf lain");
                    Console.WriteLine(cekhuruf(katamisteri, listtebakan));
                }else
                {
                    Console.WriteLine("huruf itu tidak berada di kata ini");
                    kesempatan--;
                    Console.WriteLine($"kesempatan anda tersisa {kesempatan}");
                    cluetambahan();
                }
                if(kesempatan == 0)
                {
                    Console.Clear();
                    Console.WriteLine("yahh! kamu kalah, tebakan kali ini sepertinya terlalu sulit untukmu");
                    break;
                }
            }
        }
        static void selesai()
        {
            Console.WriteLine("permainan berakhir! sampai bertemu besok!");
            Console.WriteLine("tekan enter untuk keluar");
            Console.ReadKey();
            Console.Clear();
        }
        static void cluetambahan()
        {
            if(kesempatan == 1)
            {
                Console.WriteLine("hufft, saya kasih satu clue tambahan deh, dia merupakan komting kelas TI B");
            } else if (kesempatan == 3)
            {
                Console.WriteLine("saya ulangi cluenya! kata ini merupakan anggota kelas TI B");
            }
        }
        
    }
}