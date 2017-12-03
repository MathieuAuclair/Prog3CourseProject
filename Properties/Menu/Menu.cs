using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using FinalProject.Properties;

namespace FinalProject.Properties.Menu
{
    public class Menu
    {
        private static void ValidateNumber(string std)
        {
            Regex regex = new Regex("^([1-9][0-9]{0,2}|1000)$");

            if (!regex.IsMatch(std))
                throw new InvalidNumberException(std);

        }
        public void Start()
        {
            int nbofsites = 0;
            int nbofships = 0;
            Console.WriteLine("                                                             ");
            Console.WriteLine("LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
            Console.WriteLine("-------------------------------------                        ");
            Console.WriteLine("Nombre de site       : ____             PRESS ENTER WHEN DONE");
            Console.WriteLine("                                                             ");
            Console.WriteLine("Nombre de vaisseau   : ____                                  ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("-------------------------------------                        ");


            Console.SetCursorPosition(23, 3);

            //apply regex
            try
            {
             string data1 = Console.ReadLine();
                ValidateNumber(data1);
                nbofsites = Convert.ToInt32(data1);
            }
            catch (InvalidNumberException ex)
            {
                Console.Clear();
                Console.WriteLine("                                                             ");
                Console.WriteLine("LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
                Console.WriteLine("-------------------------------------                        ");
                Console.WriteLine("Nombre de site       : ____             PRESS ENTER WHEN DONE");
                Console.WriteLine("                                                             ");
                Console.WriteLine("Nombre de vaisseau   : ____                                  ");
                Console.WriteLine("                                                             ");
                Console.WriteLine("-------------------------------------                        ");
                Console.WriteLine(ex.Message);
                

                Console.ReadLine();

                Console.Clear();

                Start();
            }

            
            
            Console.Clear();

            Console.WriteLine("                                                             ");
            Console.WriteLine("LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
            Console.WriteLine("-------------------------------------                        ");
            Console.WriteLine("Nombre de site       : "+ nbofsites + "                      ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("Nombre de vaisseau   : ____             PRESS ENTER WHEN DONE");
            Console.WriteLine("                                                             ");
            Console.WriteLine("-------------------------------------                        ");
            Console.SetCursorPosition(23, 5);

            //apply regex

            try
            {
                string data3 = Console.ReadLine();
                ValidateNumber(data3);
                nbofships = Convert.ToInt32(data3);
            }
            catch (InvalidNumberException ex)
            {
                Console.Clear();
                Console.WriteLine("                                                             ");
                Console.WriteLine("LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
                Console.WriteLine("-------------------------------------                        ");
                Console.WriteLine("Nombre de site       : ____             PRESS ENTER WHEN DONE");
                Console.WriteLine("                                                             ");
                Console.WriteLine("Nombre de vaisseau   : ____                                  ");
                Console.WriteLine("                                                             ");
                Console.WriteLine("-------------------------------------                        ");
                Console.WriteLine(ex.Message);

                Console.ReadLine();

                Console.Clear();

                Start();
            }

            Console.Clear();

            Console.WriteLine("                                                             ");
            Console.WriteLine("LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
            Console.WriteLine("-------------------------------------                        ");
            Console.WriteLine("Nombre de site       : "+ nbofsites + "                      ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("Nombre de vaisseau   : "+ nbofships + "                      ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("-------------------------------------                        ");
            Console.WriteLine("Processing...                                                ");


            Console.ReadKey();
            // Call Creation of Both Sites and ships
            

        }
        
    }
}
