using System;
using System.Collections.Generic;
using FinalProject.Properties;

namespace FinalProject.Properties.Menu
{
    public class Menu
    {
    
        public void Start()
        {
            int nbofsite;
            int nbofshipe;

            Console.WriteLine("LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
            Console.WriteLine("-------------------------------------                        ");
            Console.WriteLine("Nombre de site       : ____             PRESS ENTER WHEN DONE");
            Console.WriteLine("                                                             ");
            Console.WriteLine("Nombre de vaisseau   : ____                                  ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("-------------------------------------                        ");

            Console.SetCursorPosition(23, 2);
            nbofsite=Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            
            Console.WriteLine("LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
            Console.WriteLine("-------------------------------------                        ");
            Console.WriteLine("Nombre de site       : "+nbofsite+"                          ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("Nombre de vaisseau   : ____             PRESS ENTER WHEN DONE");
            Console.WriteLine("                                                             ");
            Console.WriteLine("-------------------------------------                        ");
            Console.SetCursorPosition(23, 4);
            nbofshipe = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
            Console.WriteLine("-------------------------------------                        ");
            Console.WriteLine("Nombre de site       : "+nbofsite+"                          ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("Nombre de vaisseau   : "+nbofshipe+"                         ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("-------------------------------------                        ");
            Console.WriteLine("Processing...                                                ");


            Console.ReadKey();

            

        }
        
    }
}
