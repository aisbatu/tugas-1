using System;
using System.Text.RegularExpressions;

namespace uts_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String teks, enkripsi = "";
            String huruf = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Regex RgX = new Regex("[^A-Za-z]");
            do
            {
                Console.Write("Teks : ");
                teks = Console.ReadLine();
            }
            while (String.IsNullOrEmpty(teks) || RgX.IsMatch(teks));
            foreach (Char t in teks)
            {
                Char temp = ' ';
                for (int i = 0; i < huruf.Length; i++)
                {
                    Char c = huruf[i];
                    if (t.Equals(c))
                    {
                        temp = huruf[i+3];
                        break;
                    }
                    else if (teks.Equals(""))
                    {
                        temp = ' ';
                    }
                } 
                enkripsi = enkripsi + temp;
            }
            Console.WriteLine("Enkripsi : "+ enkripsi);
        }
    }
}
