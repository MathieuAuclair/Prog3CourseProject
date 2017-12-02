using System;
using System.Collections.Generic;
using FinalProject.Properties;

namespace FinalProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WindowHeight = 9;
            Console.WindowWidth = 66;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "GESTION DE DÉCHET";

            FinalProject.Properties.Menu.Menu UnBeauMenu = new Properties.Menu.Menu();
            UnBeauMenu.Start();
            Console.ReadKey();
            
        }
    }
}
