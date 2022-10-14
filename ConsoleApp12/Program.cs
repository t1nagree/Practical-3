namespace практика3

{
    internal class Programm
    {
        static int[] pervayaoctavochka = { 32, 34, 39, 40, 41, 43, 46, 49, 55, 58, 61, 63 };
        static int[] vtorayaoctavocha = { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
        static int[] tretyaoctavochka = { 130, 138, 146, 155, 165, 174, 185, 196, 207, 220, 233, 246 };
        static int[] chetvertayaoctavochka = { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
        static int[] pyatayaoctavochka = { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите Октаву: F1 - первая, F2 - вторая, F3 - третья, F4 - четвёртая, F5 - пятая \n" +
                "Клавиши Пианино: D, R, F, T, G, Y, H, U, J, I, K, O ");
            while (true)
            {
                int[] piano = pianino();
                if (piano == pervayaoctavochka)
                {
                    bip(piano);
                }
                else if (piano == vtorayaoctavocha)
                {
                    bip(piano);
                }
                else if (piano == tretyaoctavochka)
                {
                    bip(piano);
                }
                else if (piano == chetvertayaoctavochka)
                { 
                    bip(piano);
                }
                else if (piano == pyatayaoctavochka)
                {
                    bip(piano);
                }
            }
            static int[] pianino()
            {
                int[] knopki = new int[13];
                {
                    ConsoleKeyInfo Key = Console.ReadKey();
                    Console.WriteLine(Key.Key);
                    if (Key.Key == ConsoleKey.F1)
                    {
                        Console.WriteLine("Октава - №1");
                        knopki = pervayaoctavochka;
                        return knopki;
                    }
                    else if (Key.Key == ConsoleKey.F2)
                    {
                        Console.WriteLine("Октава - №2");
                        knopki = vtorayaoctavocha;
                        return knopki;
                    }
                    else if (Key.Key == ConsoleKey.F3)
                    {
                        Console.WriteLine("Октава - №3");
                        knopki = tretyaoctavochka;
                        return knopki;
                    }
                    else if (Key.Key == ConsoleKey.F4)
                    {
                        Console.WriteLine("Октава - №4");
                        knopki = chetvertayaoctavochka;
                        return knopki;
                    }
                    else if (Key.Key == ConsoleKey.F5)
                    {
                        Console.WriteLine("Октава - №5");
                        knopki = pyatayaoctavochka;
                        return knopki;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите Октаву: F1 - первая, F2 - вторая, F3 - третья, F4 - четвёртая, F5 - пятая \n" + 
                            "Клавиши для игры: D, R, F, T, G, Y, H, U, J, I, K, O. ");
                        return knopki;
                    }
                }
            }

        }
        private static int[] bip(int[] piano)
        {
            int[] knopki = new int[13];
            while (true)
            {
                ConsoleKey sound = Console.ReadKey().Key;
                switch (sound)
                {
                    case ConsoleKey.D:
                        Console.Beep(piano[0], 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.R:
                        Console.Beep(piano[1] + 1000, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.F:
                        Console.Beep(piano[2] + 1000, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.T:
                        Console.Beep(piano[3] + 1000, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.G:
                        Console.Beep(piano[4] + 1000, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(piano[5] + 1000, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.H:
                        Console.Beep(piano[6] + 1000, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.U:
                        Console.Beep(piano[7] + 1000, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.J:
                        Console.Beep(piano[8] + 1000, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.I:
                        Console.Beep(piano[9], 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.K:
                        Console.Beep(piano[10], 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.O:
                        Console.Beep(piano[11], 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.F1:
                        piano = pervayaoctavochka;
                        return piano;
                        break;
                    case ConsoleKey.F2:
                        piano = vtorayaoctavocha;
                        return piano;
                        break;
                    case ConsoleKey.F3:
                        piano = tretyaoctavochka;
                        return piano;
                        break;
                    case ConsoleKey.F4:
                        piano = chetvertayaoctavochka;
                        return piano;
                        break;
                    case ConsoleKey.F5:
                        piano = pyatayaoctavochka;
                        return piano;
                        break;
                    case ConsoleKey.F10:
                        Console.WriteLine("Пасхалочка, удачной катки в доте, какой мейн у вас?)");
                        break;
                    default:
                        Console.Clear();
                        continue;
                        break;


                }
            }
        }
    }

}

