using System;

namespace pin
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите октаву нажимая на стрелочки вправо и влево\n" +
            "Нажмите F4 чтобы поменять октаву");
            int[,] oct = new[,]
            {
{ 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 },
{ 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 },
{ 523, 554, 587, 622, 659, 699, 740, 784, 830, 880, 932, 988 },
};
            string[,] octname = new[,]
            {
{ "1 ОКТАВА", "2 ОКТАВА", "3 ОКТАВА" }
};
            ConsoleKeyInfo Key = Console.ReadKey();
            int b = 0;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    b++;
                    if (b > 2)
                    {
                        b = 0;
                    }
                    Console.WriteLine(octname[0, b]);
                    Zvuk(oct, b);
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    b--;
                    if (b < 0)
                    {
                        b = 2;
                    }
                    Console.WriteLine(octname[0, b]);
                    Zvuk(oct, b);
                }
                Console.Clear();
                Console.WriteLine("Нажмите F4 чтобы поменять октаву");
            }
        }
        static void Zvuk(int[,] oct, int n)
        {
            int f = 1;
            while (f == 1)
            {
                ConsoleKeyInfo Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.Z)
                {
                    Console.Beep(oct[n, 1], 450);
                }
                if (Key.Key == ConsoleKey.S)
                {
                    Console.Beep(oct[n, 2], 450);
                }
                if (Key.Key == ConsoleKey.X)
                {
                    Console.Beep(oct[n, 3], 450);
                }
                if (Key.Key == ConsoleKey.D)
                {
                    Console.Beep(oct[n, 4], 450);
                }
                if (Key.Key == ConsoleKey.C)
                {
                    Console.Beep(oct[n, 5], 450);
                }
                if (Key.Key == ConsoleKey.F)
                {
                    Console.Beep(oct[n, 6], 450);
                }
                if (Key.Key == ConsoleKey.V)
                {
                    Console.Beep(oct[n, 7], 450);
                }
                if (Key.Key == ConsoleKey.G)
                {
                    Console.Beep(oct[n, 8], 450);
                }
                if (Key.Key == ConsoleKey.B)
                {
                    Console.Beep(oct[n, 9], 450);
                }
                if (Key.Key == ConsoleKey.H)
                {
                    Console.Beep(oct[n, 10], 450);
                }
                if (Key.Key == ConsoleKey.N)
                {
                    Console.Beep(oct[n, 11], 450);
                }
                if (Key.Key == ConsoleKey.J)
                {
                    Console.Beep(oct[n, 12], 450);
                }
                if (Key.Key == ConsoleKey.F4)
                {
                    Console.WriteLine();
                    return;
                }
            }

        }
    }

}