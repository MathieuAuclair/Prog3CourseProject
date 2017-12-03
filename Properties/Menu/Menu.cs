using System;
using System.Collections.Generic;
using FinalProject.Properties;

namespace FinalProject.Properties.Menu
{
    public class Menu
    {
    
        public void Start()
        {
            int nbofsites;
            int nbofships;
            Console.WriteLine("                                                             ");
            Console.WriteLine("LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
            Console.WriteLine("-------------------------------------                        ");
            Console.WriteLine("Nombre de site       : ____             PRESS ENTER WHEN DONE");
            Console.WriteLine("                                                             ");
            Console.WriteLine("Nombre de vaisseau   : ____                                  ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("-------------------------------------                        ");

            Console.SetCursorPosition(23, 3);
            nbofsites = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("                                                             ");
            Console.WriteLine("LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
            Console.WriteLine("-------------------------------------                        ");
            Console.WriteLine("Nombre de site       : "+ nbofsites + "                          ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("Nombre de vaisseau   : ____             PRESS ENTER WHEN DONE");
            Console.WriteLine("                                                             ");
            Console.WriteLine("-------------------------------------                        ");
            Console.SetCursorPosition(23, 5);
            nbofships = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("                                                             ");
            Console.WriteLine("LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
            Console.WriteLine("-------------------------------------                        ");
            Console.WriteLine("Nombre de site       : "+ nbofsites + "                          ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("Nombre de vaisseau   : "+ nbofships + "                         ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("-------------------------------------                        ");
            Console.WriteLine("Processing...                                                ");


            Console.ReadKey();
            // Call Creation of Both Sites and ships
            

        }
        
    }
}
