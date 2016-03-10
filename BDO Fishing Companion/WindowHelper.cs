using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BDO_Fishing_Companion
{
    public class WindowHelper
    {
        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern IntPtr GetForegroundWindow();

        public static string GetWindowTitle()
        {
            string result = "";

            IntPtr activeWindow = GetForegroundWindow();
            List<String> strListProicesses = new List<string>();
            foreach (Process process in Process.GetProcesses())
            {
                try
                {
                    if(activeWindow == process.MainWindowHandle)
                    {
                        return process.ProcessName;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
            return null;            
        }
    }
}
