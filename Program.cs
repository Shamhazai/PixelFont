using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixFont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pixone =
            {
            "███   ",
            "   █  ",
            "   █  ",
            "   █  ",
            "█████ "
            };
            string[] pixtwo =
            {
            "████  ",
            "    █ ",
            " ███  ",
            "█     ",
            "█████ "
            };
            string[] pixthr =
            {
            "████  ",
            "    █ ",
            "█████ ",
            "    █ ",
            "████  "
            };
            string[] pixfou =
            {
            "█   █ ",
            "█   █ ",
            " ████ ",
            "    █ ",
            "    █ "
            };
            string[] pixfiv =
            {
            "█████ ",
            "█     ",
            "████  ",
            "    █ ",
            "████  "
            };
            string[] pixsix =
            {
            " ████ ",
            "█     ",
            "████  ",
            "█   █ ",
            " ███  "
            };
            string[] pixsev =
            {
            " ███  ",
            "█   █ ",
            "    █ ",
            "    █ ",
            "    █ "
            };
            string[] pixeig =
            {
            " ███  ",
            "█   █ ",
            "█████ ",
            "█   █ ",
            " ███  "
            };
            string[] pixnin =
            {
            " ███  ",
            "█   █ ",
            " ████ ",
            "    █ ",
            " ███  "
            };
            string[] pixnul =
            {
            " ███  ",
            "█  ██ ",
            "█ █ █ ",
            "██  █ ",
            " ███  "
            };
            string[] pixdot =
            {
            "      ",
            "      ",
            "      ",
            "      ",
            " █    "
            };
            string[] pixcom =
            {
            "      ",
            "      ",
            "      ",
            "      ",
            " █    ",
            " █    "
            };
            Console.Write("Введите число без пробелов(допускаются , м .):");
            string a = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
                switch (a[i])
                {
                    case '0':
                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int k = 0; k < pixnul.Length; k++) {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - (6 * (a.Length - 1)/2) + 6 * i, Console.WindowHeight / 2 - 3 + k);
                            Console.WriteLine(pixnul[k]);
                        }
                        break;
                    case '1':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        for (int k = 0; k < pixone.Length; k++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - (6 * (a.Length - 1) / 2) + 6 * i, Console.WindowHeight / 2 - 3 + k);
                            Console.WriteLine(pixone[k]);
                        }
                        break;
                    case '2':
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (int k = 0; k < pixtwo.Length; k++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - (6 * (a.Length - 1) / 2) + 6 * i, Console.WindowHeight / 2 - 3 + k);
                            Console.WriteLine(pixtwo[k]);
                        }
                        break;
                    case '3':
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        for (int k = 0; k < pixthr.Length; k++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - (6 * (a.Length - 1) / 2) + 6 * i, Console.WindowHeight / 2 - 3 + k);
                            Console.WriteLine(pixthr[k]);
                        }
                        break;
                    case '4':
                        Console.ForegroundColor = ConsoleColor.Gray;
                        for (int k = 0; k < pixfou.Length; k++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - (6 * (a.Length - 1) / 2) + 6 * i, Console.WindowHeight / 2 - 3 + k);
                            Console.WriteLine(pixfou[k]);
                        }
                        break;
                    case '5':
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        for (int k = 0; k < pixfiv.Length; k++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - (6 * (a.Length - 1) / 2) + 6 * i, Console.WindowHeight / 2 - 3 + k);
                            Console.WriteLine(pixfiv[k]);
                        }
                        break;
                    case '6':
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        for (int k = 0; k < pixsix.Length; k++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - (6 * (a.Length - 1) / 2) + 6 * i, Console.WindowHeight / 2 - 3 + k);
                            Console.WriteLine(pixsix[k]);
                        }
                        break;
                    case '7':
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        for (int k = 0; k < pixsev.Length; k++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - (6 * (a.Length - 1) / 2) + 6 * i, Console.WindowHeight / 2 - 3 + k);
                            Console.WriteLine(pixsev[k]);
                        }
                        break;
                    case '8':
                        Console.ForegroundColor = ConsoleColor.White;
                        for (int k = 0; k < pixeig.Length; k++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - (6 * (a.Length - 1) / 2) + 6 * i, Console.WindowHeight / 2 - 3 + k);
                            Console.WriteLine(pixeig[k]);
                        }
                        break;
                    case '9':
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        for (int k = 0; k < pixnin.Length; k++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - (6 * (a.Length - 1) / 2) + 6 * i, Console.WindowHeight / 2 - 3 + k);
                            Console.WriteLine(pixnin[k]);
                        }
                        break;
                    case '.':
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int k = 0; k < pixdot.Length; k++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - (6 * (a.Length - 1) / 2) + 6 * i, Console.WindowHeight / 2 - 3 + k);
                            Console.WriteLine(pixdot[k]);
                        }
                        break;
                    case ',':
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        for (int k = 0; k < pixcom.Length; k++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - (6 * (a.Length - 1) / 2) + 6 * i, Console.WindowHeight / 2 - 3 + k);
                            Console.WriteLine(pixcom[k]);
                        }
                        break;
                }
            Console.ReadLine();
        }
    }
}

