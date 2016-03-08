using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDO_Fishing_Companion
{
    public static class CC
    {
        public static void WriteGreen(string text)
        {
            Console.ForegroundColor = Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write(text);
            Console.ForegroundColor = Console.ForegroundColor = System.ConsoleColor.White;
        }

        public static void WriteGreenLine(string text)
        {
            Console.ForegroundColor = Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = Console.ForegroundColor = System.ConsoleColor.White;
        }

        public static void WriteBlue(string text)
        {
            Console.ForegroundColor = Console.ForegroundColor = System.ConsoleColor.Cyan;
            Console.Write(text);
            Console.ForegroundColor = Console.ForegroundColor = System.ConsoleColor.White;
        }

        public static void WriteBlueLine(string text)
        {
            Console.ForegroundColor = Console.ForegroundColor = System.ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ForegroundColor = Console.ForegroundColor = System.ConsoleColor.White;
        }

        public static void WriteRed(string text)
        {
            Console.ForegroundColor = Console.ForegroundColor = System.ConsoleColor.Red;
            Console.Write(text);
            Console.ForegroundColor = Console.ForegroundColor = System.ConsoleColor.White;
        }

        public static void WriteRedLine(string text)
        {
            Console.ForegroundColor = Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = Console.ForegroundColor = System.ConsoleColor.White;
        }

        public static void WriteBanner()
        {
            CC.WriteGreenLine(BDO_Fishing_Companion.banner1);
            CC.WriteBlueLine(BDO_Fishing_Companion.banner2);
            CC.WriteGreenLine(BDO_Fishing_Companion.banner3);
        }
    }
}
