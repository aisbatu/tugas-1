using System;
namespace esyah
{
    class Program
    {
        static int code1;
        static int code2;
        static int code3;
        static int hasiltambah;
        static int hasilkali;
        static int level = 5;
        static int kesempatan = 3;
        static String tebakan1;
        static String tebakan2;
        static String tebakan3;
        static bool gamestart;
        static void Main(string[] args)
        {
            init();
            while(kesempatan > 0 && level <= 5)
            {
                Console.Clear();
                gamestart = playgame(level);
                if(gamestart)
                {
                    level++;
                    if(level <= 5)
                    {
                        Console.WriteLine("benar! level anda naik ke "+level);Console.ReadLine();
                    }
                }else
                    {
                        kesempatan--;
                        Console.WriteLine("kesempatan anda tersisa "+kesempatan);Console.ReadLine();
                    }
                if(level > 5 && kesempatan > 0)
                {
                    Console.WriteLine("selamat! anda menang\npencet enter untuk menutup");
                } else 
                if(kesempatan <= 0 && level > 1)
                {
                    Console.WriteLine("coba lagi lain kali! anda sudah berhasil melewati beberapa level loh!");
                } else 
                
                if(kesempatan <= 0 && level == 1)
                {
                    Console.WriteLine("anda kalah! maaf yaa");
                }
            }
            Console.Write("\npencet enter untuk keluar"); Console.ReadKey();
        }

        static void init()
        {
            level = 1;
            kesempatan = 3;
            gamestart = true;
        }
        static bool playgame(int level)
        {
            Random rng = new Random();
            code1 = rng.Next(1,level+1);
            code2 = rng.Next(1,level+1);
            code3 = rng.Next(1,level+1);
            
            hasiltambah=code1+code2+code3;
            hasilkali=code1*code2*code3;
            {
                
            }
            Console.WriteLine("haloo agen muda!\nini adalah misi percobaan tahap "+level+"\ncoba tebak ini!");
            Console.WriteLine("- jika ditambah hasilnya "+hasiltambah+"\n- jika dikali hasilnya "+hasilkali);
            Console.Write("\nkode 1 :"); tebakan1 = Console.ReadLine();
            Console.Write("kode 2:"); tebakan2 = Console.ReadLine();
            Console.Write("kode 3 :"); tebakan3 = Console.ReadLine();
            if(tebakan1 == code1.ToString() && tebakan2 == code2.ToString() && tebakan3 == code3.ToString())
            {
                Console.WriteLine("kode anda benar!\npencet enter untuk melanjutkan");
                return true;
            }else 
            {
                Console.WriteLine("maaf! kode anda salah\npencet enter untuk mencoba lagi");Console.ReadLine();
                return false;
            }
        }
    }
}
