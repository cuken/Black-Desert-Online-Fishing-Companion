using System;
using System.Threading;

namespace BDO_Fishing_Companion
{
    public class Spinner : IDisposable
    {
        string[] sequence;
        private int counter = 0;
        private readonly int left;
        private readonly int top;
        private readonly int delay;
        private bool active;
        private readonly Thread thread;

        public Spinner(string animation = "kirby",int left = 0, int top = 0, int delay = 100)
        {
            this.left = left;
            this.top = top;
            this.delay = delay;
            switch (animation)
            {
                case "kirby":
                    sequence = new string[] { @"<(' ')>", @" <(' <)", @"<(   )>", @" (> ')>" };
                    break;
                case "dots":
                    sequence = new string[] { ".", "..", "...", "   " };
                    break;
                case "cross":
                    sequence = new string[] { "+", "x" };
                    break;
                case "arrow":
                    sequence = new string[] { "V", "<", "^", ">" };
                    break;
                case "dash":
                    default:
                    sequence = new string[] { @"/", @"-", @"\", @"|" };
                    break;
            }            

            thread = new Thread(Spin);

        }

        public void Start()
        {
            active = true;
            try
            {         
                if (!thread.IsAlive)
                    thread.Start();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Stop()
        {
            active = false;
            Draw("");
            
        }

        private void Spin()
        {
            while(true)
            {
                while (active)
                {
                    Turn();
                }

                Thread.Sleep(50);
            }
        }            

        private void Draw(string c)
        {
            //Console.SetCursorPosition(left, top);
            Console.Write(c);
            Thread.Sleep(delay);
            Clean(c);
            
        }

        private void Clean(string c)
        {
            for (int i = c.Length; i > 0; i--)
            {
                Console.Write("\b");
                //Console.Write(i);
            }
        }

        private void Turn()
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                Draw(sequence[i]);                               
            }            
        }

        public void Dispose()
        {
            Stop();
        }
    }
}