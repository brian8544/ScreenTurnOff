/*
Credits:
brian8544                   > source code
Leo Liu                     > Microsoft opcodes
Papirus Development Team    > icon for project
*/

using System;
using System.Runtime.InteropServices;

namespace ScreenTurnOff
{
    public class ScreenTurnOff
    {   
        //Import required libraries
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        //Initialize opcodes
        private static int WM_SYSCOMMAND = 0x0112;
        private static uint SC_MONITORPOWER = 0xF170;

        //Runtime
        public static void Main(string[] args)
        {
            Console.Title = ("brian8544 - github.com/brian8544");
            Console.WriteLine("brian8544 - github.com/brian8544");
            SendMessage(GetConsoleWindow(), WM_SYSCOMMAND, (IntPtr)SC_MONITORPOWER, (IntPtr)2);
            Environment.Exit(0);
        }
    }
}