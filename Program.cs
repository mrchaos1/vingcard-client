using System;
using System.Diagnostics.Tracing;
using System.Net;
using System.IO;
using System.ComponentModel;
using System.Configuration;
using System.Collections.Specialized;
using System.Xml;
using System.Web.UI;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using System.Runtime.InteropServices;
using System.Reflection;
using System.Reflection.Emit;
using System.Diagnostics;

namespace App
{
    public class Program
    {
        [DllImport("pmsif.dll", SetLastError = true)]
        public static extern int PMSifRegister(int szLicense, string szApplName);

        public static void Main(string[] args)
        {
            int License = 42963069;
            string AppName = "test_client";

            try
            {
                int Result = PMSifRegister(License, AppName);

                if (Result == 1)
                {
                    Console.WriteLine("Write data successfully!");
                }
                else
                {
                    Console.WriteLine("Write data fail.");
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Ошибка библиотеки: " + err.Message);
            }

            Console.WriteLine("Завершено.");
            Console.ReadLine();
        }
    }
}