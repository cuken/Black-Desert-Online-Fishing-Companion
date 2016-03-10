using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;
using System.Threading;

namespace BDO_Fishing_Companion
{
    class BDO_Fishing_Companion
    {
        System.Timers.Timer t1 = new System.Timers.Timer();
        static ManualResetEvent sm = new ManualResetEvent(false);

        public static string banner1 = File.ReadAllText("./a1.txt");
        public static string banner2 = File.ReadAllText("./a2.txt");
        public static string banner3 = File.ReadAllText("./a3.txt");
        public static Spinner spinner = new Spinner("dots", Console.CursorLeft, Console.CursorTop, 100);

        public static string windowTitle = "";

        static int pole1X = 0;
        static int pole1Y = 0;
        static int pole2X = 0;
        static int pole2Y = 0;
        static int pole3X = 0;
        static int pole3Y = 0;

        static Point point;

        static void Main(string[] args)
        {

            CC.WriteBanner();
            Console.WriteLine(DateTime.Now.ToLocalTime().ToString());

            HotKeyManager.RegisterHotKey(Keys.F, KeyModifiers.Shift);
            HotKeyManager.RegisterHotKey(Keys.F1, KeyModifiers.Alt);

            CC.WriteGreen(">");
            string input = Console.ReadLine();

            while(Exit(input))
            {
                switch(input.ToLower())
                {
                    case "start":
                    case "fish":
                        StartFishing();
                        break;
                    case "testkey":
                        TestKeyboard();
                        break;
                    case "testmouse":
                        TestMouse();
                        break;
                    case "testwindow":
                        GetWindowTitle();
                        break;
                    case "setup":
                        Setup();
                        break;                        
                }

                CC.WriteGreen(">");
                input = Console.ReadLine();
            }       

        }
       
        private static void GetWindowTitle()
        {
            spinner.Start();
            HotKeyManager.HotKeyPressed += HotKeyManager_HotKeyPressedWindow;
            sm.WaitOne();
            spinner.Stop();
            HotKeyManager.HotKeyPressed -= HotKeyManager_HotKeyPressedWindow;
            sm.Reset();
        }

        private static void HotKeyManager_HotKeyPressedWindow(object sender, HotKeyEventArgs e)
        {
            windowTitle = WindowHelper.GetWindowTitle();
            CC.WriteBlueLine(windowTitle);
            sm.Set();
        }

        private static void Setup()
        {
            spinner.Start();
            HotKeyManager.HotKeyPressed += HotKeyManager_HotKeyPressed;
            sm.WaitOne();
            spinner.Stop();
            Console.WriteLine($"X:{pole1X} | Y:{pole1Y}");
            HotKeyManager.HotKeyPressed -= HotKeyManager_HotKeyPressed;
            sm.Reset();
        }

        private static void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            point = new Point(Cursor.Position.X, Cursor.Position.Y);
            pole1X = Cursor.Position.X;
            pole1Y = Cursor.Position.Y;
            sm.Set();
        }        

        private static void TestMouse()
        {            
            Cursor.Position = new System.Drawing.Point(pole1X, pole1Y);
            Mouse.SendLeftClick();
            Thread.Sleep(1000);
            Mouse.SendRightClick();
        }

        private static void TestKeyboard()
        {
            spinner.Start();
            Thread.Sleep(10000);
            spinner.Stop();
            SendKeys.SendWait("Hello Ryan");
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
