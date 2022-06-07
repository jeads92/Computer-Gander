using System;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ComputerGander
{
    internal static class Program
    {
        // Long variables to keep track of packets received.
        public static long packetCount1 = 0;
        public static long packetCount2 = 0;



        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}