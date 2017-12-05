using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using FinalProject.Properties;
using System.Threading;

namespace FinalProject.Properties.Menu
{
    public static class Menu
    {
        public static int nbofships =0;
        public static int nbofsites = 0;
        public static void whileRunning()
        {
            Console.WriteLine("Step 1 : {0}");
        }
        private static void ValidateNumber(string std)
        {
            Regex regex = new Regex("^([1-9][0-9]{0,2}|1000)$");

            if (std != null)
            {
                if (regex.IsMatch(std))
                {
                    return;
                }
            }
            
            throw new InvalidNumberException(std);

        }
        public static void Start()
        {
            Console.WriteLine("                                                                     ");
            Console.WriteLine("        LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
            Console.WriteLine("        =====================================                        ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("        Nombre de site       : ____          PRESS ENTER             ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("        Nombre de vaisseau   : ____                                  ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("        =====================================                        ");
            Console.WriteLine("        'Saving the fucking universe'                                ");


            Console.SetCursorPosition(31, 4);

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
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
                Console.WriteLine("        =====================================                        ");
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        Nombre de site       : " + nbofsites + "                     ");
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        Nombre de vaisseau   : " + nbofships + "                     ");
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        =====================================                        ");
                Console.WriteLine("        'Saving the fucking universe'                                ");
                Console.WriteLine(ex.Message);
                

                Console.ReadLine();

                Console.Clear();

                Start();
            }

            
            
            Console.Clear();

            Console.WriteLine("                                                                     ");
            Console.WriteLine("        LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
            Console.WriteLine("        =====================================                        ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("        Nombre de site       : "+nbofsites+"                         ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("        Nombre de vaisseau   : ____          PRESS ENTER             ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("        =====================================                        ");
            Console.WriteLine("        'Saving the fucking universe'                                ");
            Console.SetCursorPosition(31, 6);

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
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
                Console.WriteLine("        =====================================                        ");
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        Nombre de site       : " + nbofsites + "                     ");
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        Nombre de vaisseau   : " + nbofships + "                     ");
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        =====================================                        ");
                Console.WriteLine(ex.Message);

                Console.ReadLine();

                Console.Clear();

                Start();
            }

            
            int x = 0;
            while (x < 25)
            {
                if( x % 2 != 1)
                {
                    Console.Clear();

                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("        LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
                    Console.WriteLine("        =====================================                        ");
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("        Nombre de site       : " + nbofsites + "                     ");
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("        Nombre de vaisseau   : " + nbofships + "                     ");
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("        =====================================                        ");
                    Console.WriteLine("        Processing...                                                ");
                    Console.WriteLine("                'Saving the fucking universe'                        ");
                    x++;
                    Thread.Sleep(75);

                }
                else
                {
                    Console.Clear();
                  
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("        LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
                    Console.WriteLine("        =====================================                        ");
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("        Nombre de site       : " + nbofsites + "                     ");
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("        Nombre de vaisseau   : " + nbofships + "                     ");
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("        =====================================                        ");
                    Console.WriteLine("        Processing.....                                              ");
                    Console.WriteLine("                'Saving the fucking universe'                        ");
                    x++;
                    Thread.Sleep(75);

                }

            }


            //return (nbofsites,nbofships)
            //call creation avec valeur (nbofsites,nbofships) //(nombre de sites,nombre de vaisseau)
            //whileRunning();

        }
        public static void speach(string msg)
        {
            Console.Clear();
            Console.WriteLine("                                                                     ");
            Console.WriteLine("        LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
            Console.WriteLine("        -------------------------------------                        ");
            Console.WriteLine("        Nombre de site       : " + nbofsites + "                     ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("        Nombre de vaisseau   : " + nbofships + "                     ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("        -------------------------------------                        ");
            Console.WriteLine(msg);         

        }
        
    }
}
