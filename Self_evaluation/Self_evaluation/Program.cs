using System;

namespace Self_evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kaikki tehtävät tehty yhteen, tehtävien tarkistus tehdään valikon kautta
            string input;
            Console.WriteLine("Select the assignment you wish to check (number 1-4):");
            Console.WriteLine("");
            //Laitetaan käyttäjän valinta string arvoon
            input = Console.ReadLine();
            Console.WriteLine("");
            //Käsitellään edellä annettu arvo.
            //Jos mahdollista muuttaa int arvoksi, tarkistetaan mikä numero.
            //Jos annettu arvo ei ole numero väliltä 1-4, mitään ei tapahdu.
            if (int.TryParse(input, out int select) == true)
            {
                //Tehtävä 1 valinta
                if (select == 1)
                {

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
