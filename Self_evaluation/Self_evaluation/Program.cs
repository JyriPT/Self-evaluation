﻿using System;

namespace Self_evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kaikki tehtävät tehty yhteen, tehtävien tarkistus tehdään valikon kautta
            string selection;
            Console.WriteLine("Select the assignment you wish to check (number 1-4):");
            Console.WriteLine("");
            //Laitetaan käyttäjän valinta string arvoon
            selection = Console.ReadLine();
            Console.WriteLine("");
            //Käsitellään edellä annettu arvo.
            //Jos mahdollista muuttaa int arvoksi, tarkistetaan mikä numero.
            //Jos annettu arvo ei ole numero väliltä 1-4, mitään ei tapahdu.
            if (int.TryParse(selection, out int select) == true)
            {
                //Tehtävä 1 valinta
                if (select == 1)
                {
                    Console.WriteLine("Please input a phrase:");
                    string input = Console.ReadLine();

                    Console.WriteLine("Output:");

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(i + ". " + input);
                    }
                }
                //Tehtävä 2 valinta
                else if (select == 2)
                {

                }
                //Tehtävä 3 valinta
                else if (select == 3)
                {

                }
                //Tehtävä 4 valinta
                else if (select == 4)
                {

                } else
                { 
                    Console.WriteLine("Invalid selection, please reboot.");
                }
            }
            
        }
    }
}
