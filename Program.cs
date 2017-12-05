using System;
using System.Collections.Generic;
using FinalProject.Properties;
using FinalProject.Properties.Menu;

namespace FinalProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "GESTION DE DÉCHET";
            Console.WindowHeight = 12;
            Console.WindowWidth = 66;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Menu.Start();

            SortingCenter sortingCenter = new OddSortingCenter(FinalProject.Properties.Menu.Menu.nbofships, null);
            Menu.Start();
            
            Console.ReadKey();
        }
    }
}
