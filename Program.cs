using System;
using System.Collections.Generic;
using FinalProject.Properties;

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
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();


            FinalProject.Properties.Menu.Menu.Start();
            SortingCenter sortingCenter = new OddSortingCenter(FinalProject.Properties.Menu.Menu.nbofships, null);
            Console.ReadKey();


            
        }
    }
}
