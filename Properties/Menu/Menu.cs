using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using FinalProject.Properties;
using System.Threading;

namespace FinalProject.Properties.Menu
{
    public static class Menu
    {
        public static int nbofShipsPerSites=0;
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
            try
            {
                nbofsites = Convert.ToInt32(Console.ReadLine());
                speach("");
            }
            catch (Exception e)
            {
                Console.WriteLine("you made a typo...");
                Console.ReadKey();
                Start();
            }

            Console.SetCursorPosition(31, 6);
            try
            {
                nbofsites = Convert.ToInt32(Console.ReadLine());
                speach("");
            }
            catch (Exception e)
            {
                Console.WriteLine("you made a typo...");
                Console.ReadKey();
                Start();
            }

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
            Thread.Sleep(50);
        }
        
    }
}
