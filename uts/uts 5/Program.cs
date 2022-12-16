using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uts5
{
    class Program
    {
        static void Main(string[] args)
        {
            int kesalahan = 0;
            String jawaban = " ";
            bool slh = false, mng = false, klh = false, bnr = false;
            Console.Clear();
            string[] soal = new string[10];
            soal[0] = "gula";
            soal[1] = "garam";
            soal[2] = "micin";
            soal[3] = "lada";
            soal[4] = "merica";
            soal[5] = "kopi";
            soal[6] = "cabe";
            soal[7] = "ketumbar";
            soal[8] = "bawang";
            soal[9] = "saos";
            Random rng = new Random();
            var random = rng.Next(0,9);
            string soalgame = soal[random];
            char[] guess = new char[soalgame.Length];

            for(int i = 0; i < soalgame.Length; i++)
            {
                guess[i] = '_';
            }
            while(mng == false && klh == false)
            {
                Console.Write("Huruf tebakan : ");
                char playerguess = char.Parse(Console.ReadLine());
                for (int j = 0; j < soalgame.Length; j++)
                {
                    if (playerguess == soalgame [j])
                    {
                        bnr = true;
                        guess[j]= playerguess;
                    }
                    else if (j == soalgame.Length - 1 && bnr == false)
                    {
                        slh = true;
                    }
                }
                Console.Clear();
                jawaban = new String (guess);
                if (slh == true)
                {
                    Console.WriteLine("maaf! tebakan anda salah");
                    kesalahan++;
                    slh = false;
                }
                bnr = false;
                Console.WriteLine(guess);
                Console.WriteLine();
                switch(kesalahan)
                {
                    case 1 :
                        Console.WriteLine("|__");
                        break;
                    case 2 :
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 3 :
                    Console.WriteLine(" |/");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine("|__");
                    break;
                    case 4 :
                        Console.WriteLine("____");
                        Console.WriteLine(" |/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 5 :
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 6 :
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 7 :
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 8 :
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 9 :
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |      / \\");
                        Console.WriteLine("|__");
                        break;
                    case 10 :
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |      / \\");
                        Console.WriteLine("|__");
                        break;
                }

                if (jawaban == soalgame)
                {
                    Console.WriteLine("selamat! anda menang");
                    mng = true;
                }
                else if (kesalahan == 10 && jawaban != soalgame)
                {
                    Console.WriteLine("anda kalah!");
                    klh = true;
                }
            }
        }
    }
}