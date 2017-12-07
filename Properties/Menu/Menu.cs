using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using FinalProject.Properties;
using System.Threading;

namespace FinalProject.Properties.Menu
{
    public static class Menu
    {
        public static int nbofShipsPerSites;
        public static int nbofships =0;
        public static int nbofsites = 0;
       
        private static void ValidateNumber(string std)
        {
            Regex regex = new Regex("^([1-9][0-9]{0,2}|1000)$");

            if (!regex.IsMatch(std))
                throw new InvalidNumberException(std);

        }
        public static void Start(int step)
        {
            if(step == 1)
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
                string data1 = Console.ReadLine();
                ValidateNumber(data1);
                nbofsites = Convert.ToInt32(data1);
                Start(2);
            }
            catch (InvalidNumberException ex)
            {
                Console.Clear();
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
                Console.WriteLine("        =====================================                        ");
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        Nombre de site       : ____                                  ");
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        Nombre de vaisseau   : ____                                  ");
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        =====================================                        ");
                Console.WriteLine(ex.Message);
    
                Console.ReadLine();

                Console.Clear();

                Start(1); // u failed at step 1 , try step 1 again faggotlord /$%?&$
                }
            }
            if(step==2)
            {
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

                try
                {
                 string okay1;
                 okay1 = Console.ReadLine();
                 ValidateNumber(okay1);
                 nbofships = Convert.ToInt32(okay1);
                }
                catch (InvalidNumberException ex)
                {
                    Console.Clear();
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("        LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
                    Console.WriteLine("        =====================================                        ");
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("        Nombre de site       : "+nbofsites+"                         ");
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("        Nombre de vaisseau   : ____                                  ");
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("        =====================================                        ");
                    Console.WriteLine(ex.Message);

                    Console.ReadLine();

                    Console.Clear();

                    Start(2); // u failed at step 2 , try step 2 again faggotlord /$%?&$

                }
                Console.Clear();
                Console.WriteLine("        LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
                Console.WriteLine("        =====================================                        ");
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        Nombre de site       : "+nbofsites+"                         ");
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        Nombre de vaisseau   : "+nbofships+"                         ");
                Console.WriteLine("                                                                     ");
                Console.WriteLine("        =====================================                        ");
                nbofShipsPerSites = nbofships / nbofsites;
            }
        }
        public static void speach(string msg)
        {
            Console.Clear();
            Console.WriteLine("        LOGICIEL DE GESTION DE DÉCHET TOXIQUE                        ");
            Console.WriteLine("        =====================================                        ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("        Nombre de site       : " + nbofsites + "                         ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("        Nombre de vaisseau   : " + nbofships + "                         ");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("        =====================================                        ");

            Console.WriteLine(msg);
            Thread.Sleep(50);
        }
        
    }
}
