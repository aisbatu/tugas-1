using System;

namespace array
{
    class Program
    {
        static char[,] tank =
        {
            {' ','1','2','3','4','5'},
            {'1','~','~','~','~','~'},
            {'2','~','~','~','~','~'},
            {'3','~','~','~','~','~'},
            {'4','~','~','~','~','~'},
            {'5','~','~','~','~','~'},
        };
        static int[,] ans = 
        {
            {2,1},
            {3,5},
            {2,5},
        };
        static int[,] recent = 
        {
            {0,0},
            {0,0},
            {0,0},
        };
        static int[] guess = {0,0};
        static int jb = 0;
        static bool gs = true;
        static int truth = 0;
        static void Main(string[] args)
        {
            while(gs)
            {
                drawtank();
                try
                {
                    Console.Write("choose line : "); guess[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("choose column: "); guess[1] = Convert.ToInt32(Console.ReadLine());
                }catch(Exception)
                {
                    Console.WriteLine("error! angka yang diinput tidak valid!");
                }
                truth = cektank();
                if(truth == 2)
                {
                    Console.WriteLine("hancur!");
                }
                else if (truth == 1)
                {
                    Console.WriteLine("boom! tank hancur");
                    jb++;
                }
                else
                {
                    Console.WriteLine("miss! meleset");
                }
                if(jb >= 3)
                {
                    drawtank();
                    Console.WriteLine("\nmenang! tank hancur semua!");
                    gs=false;
                }
                Console.WriteLine();
            }
        }
        static void drawtank()
        {
            for(int i=0;i<6;i++)
            {

                for(int j=0;j<6;j++)
                {
                    Console.Write(tank[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int cektank()
        {
            for(int i=0;i<3;i++)
            {
                if(recent[i,0] == guess[0] && recent[i,1] == guess[1])
                {
                    return 2;
                }
            }
            for(int i=0;i<3;i++)
            {
                if(ans[i,0] == guess[0] && ans[i,1] == guess[1])
                {
                    tank[guess[0],guess[1]]='x';
                    recent[1,0] = guess[0];
                    recent[i,1] = guess[1];
                    return 1;
                }
                else
                {
                    tank[guess[0],guess[1]] = '0';
                }
            }
            return 0;
        }
    }
}