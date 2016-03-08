using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace BDO_Fishing_Companion
{
    class BDO_Fishing_Companion
    {
        System.Timers.Timer t1 = new System.Timers.Timer();

        public static string banner1 = File.ReadAllText("./a1.txt");
        public static string banner2 = File.ReadAllText("./a2.txt");
        public static string banner3 = File.ReadAllText("./a3.txt");

        static void Main(string[] args)
        {

            CC.WriteBanner();
            Console.WriteLine(DateTime.Now.ToLocalTime().ToString());

            //Console.Read();

            //for(int i = 0; i < 200; i++)
            //{
            //    Cursor.Position = new System.Drawing.Point(500 + i, 500);
            //    Mouse.SendClick();
            //}

            CC.WriteGreen(">");
            string input = Console.ReadLine();

            while(Exit(input))
            {
                switch(input)
                {
                    case "start":
                    case "fish":
                        StartFishing();
                        break;
                }

                CC.WriteGreen(">");
                input = Console.ReadLine();
            }       

        }

        static void StartFishing()
        {
            Console.Clear();
            
            CC.WriteBlueLine("Starting fishing!");

            int poleDurability;

            CC.WriteGreen("What is the durability of your Pole? ");
            int.TryParse((Console.ReadLine()), out poleDurability);

            if (poleDurability <= 0)
                CC.WriteRedLine($"{poleDurability} was not greater than 0, or in a weird format, please provide an int like 10 or 30");

            //SKIPPING Fishing Skill consideration.

            int afkCatchDuration = 5;

            CC.WriteGreenLine("in future versions we'll account for fishing speed, assuming 5 minutes per afk fish catch");
            //int.TryParse((Console.ReadLine()), out poleDurability);

            CC.WriteBlue("Press any key once you've started fishing!");

            Console.ReadLine();

            DateTime now = DateTime.Now;
            Console.WriteLine("Fishing started at " + now.ToShortTimeString());

            DateTime fishingComplete = now.AddMinutes(poleDurability * afkCatchDuration);
            CC.WriteGreen($"You will need to refresh your pole @ {fishingComplete.ToShortTimeString()}");

            Console.ReadLine();          

        }

        

        static bool Exit(string text)
        {
            switch (text.ToLower())
            {
                case "q":
                case "x":
                case "exit":
                case "quit":
                case "leave":
                    return false;
                default:
                    return true;
            }
        }
    }
}
