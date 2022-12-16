using System;

namespace adventure_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat Datang! di Adventure Game");
            Console.WriteLine("silahkan masukkan nama anda");
            Newbie pemain = new Newbie();
            pemain.nama = Console.ReadLine();
            Console.WriteLine("hai! "+pemain.nama+" siap untuk memulai permainan?[y/n]");
            string memulai = Console.ReadLine();
            if(memulai == "y")
            {
                Console.WriteLine(pemain.nama+" memasuki permainan..");
                musuh musuh1 = new musuh("serigala");
                Console.WriteLine(pemain.nama+" sedang menghadapi "+musuh1.nama); 
                Console.WriteLine(musuh1.nama+" menyerangmu ");
                Console.WriteLine("pilih salah satu skillmu :");
                Console.WriteLine("1. memukul");
                Console.WriteLine("2. menyerang");
                Console.WriteLine("3. berlindung");
                Console.WriteLine("4. melarikan diri");

                while(!pemain.tewas || !musuh1.tewas)
                {
                    string aksipemain = Console.ReadLine();
                    switch(aksipemain)
                    {
                        case "1" : 
                        Console.WriteLine(pemain.nama+" sedang memukul");
                        musuh1.diserang(pemain.kekuatan);
                        pemain.pengalaman = 0.3f;
                        musuh1.menyerang(musuh1.kekuatan);
                        pemain.diserang(musuh1.kekuatan);
                        Console.Write("nyawa pemain : "+pemain.nyawa+"\nnyawa musuh : "+musuh1.nyawa);Console.ReadLine();
                        break;

                        case "2" : 
                        pemain.menyerang();
                        pemain.pengalaman = 0.9f;
                        musuh1.diserang(pemain.kekuatan);
                        Console.Write("nyawa pemain : "+pemain.nyawa+"\nnyawa musuh : "+musuh1.nyawa);Console.ReadLine();
                        break;
                        case "3" :

                        pemain.penyembuhan();
                        Console.WriteLine("mana sedang diisi kembali");
                        musuh1.menyerang(musuh1.kekuatan);
                        pemain.diserang(musuh1.kekuatan);
                        break;
                        
                        case "4" :
                        Console.WriteLine("pemain melarikan diri");
                        break;
                    }
                    continue;
                }

                Console.WriteLine(pemain.nama+" mendapat "+pemain.pengalaman+" point pengalaman");
            }else
            {
                Console.WriteLine("dadahh");
                Console.Read();
            }

        }
    }
    class Newbie
    {
        public int nyawa{ get; set; }
        public string nama{ get; set; }
        public int kekuatan{ get; set; }
        public int keahlian{ get; set; }
        public bool tewas{ get; set; }
        public float pengalaman{ get; set; }
        Random rnd = new Random();

        public Newbie()
        {
            nyawa = 120;
            keahlian = 0;
            kekuatan = 1;
            tewas = false;
            pengalaman = 0f;
            nama = "pemain baru";
        }
        public void menyerang()
        {
            if(keahlian > 0)
            {
                Console.WriteLine("anda menyerang!");
                kekuatan = kekuatan + rnd.Next(10,50);
                keahlian--;
            } else
            {
                Console.WriteLine("maaf! mana anda kurang");
            }
            
        }
        public void diserang(int jumlahkerusakan)
        {
            Console.WriteLine(nama+" terkena serangan sebanyak "+ jumlahkerusakan);
            nyawa = nyawa - jumlahkerusakan;

            if(nyawa <= 0);
            {
                nyawa = 0;
                mati();
            }
        }
        public void penyembuhan()
        {
            keahlian = 3;
            kekuatan = 1;
        }
         public void mati()
        {
            Console.WriteLine("anda telah dikalahkan\npermainan berakhir");
            tewas = true;
        }
    }
    class musuh
    {
        public int nyawa{ get; set; }
        public string nama{ get; set; }
        public int kekuatan{ get; set; }
        public bool tewas{ get; set; }
        Random rnd = new Random();

        public musuh(string Nama)
        {
            nyawa = 90;
            nama = Nama;
        }
        public void menyerang(int kerusakan)
        { 
            kekuatan = rnd.Next(1,10);
        }
        public void diserang(int jumlahkerusakan)
        {
            Console.WriteLine(nama+" terkena serangan sebanyak "+ jumlahkerusakan);
            nyawa = nyawa - jumlahkerusakan;

            if(nyawa <= 0)
            {
                nyawa = 0;
                mati();
            }
        }
        public void mati()
        {
            Console.WriteLine(nama+" telah dikalahkan");
            tewas = true;
        }
    }
}