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
                    int order = 0;

                    Console.WriteLine("Please input a phrase:");
                    string input = Console.ReadLine();

                    Console.WriteLine("Output:");

                    for (int i = input.Length; i > 0; i--)
                    {
                        Console.WriteLine(order + ". " + input);

                        order++;
                    }
                }
                //Tehtävä 3 valinta
                else if (select == 3)
                {
                    Console.WriteLine("Please input a number:");
                    string input = Console.ReadLine();
                    int count = 0;
                    int number;

                    do
                    {
                        if (int.TryParse(input, out number) == true && number != -1)
                        {
                            count += number;
                            input = Console.ReadLine();

                        } else if (int.TryParse(input, out number) == false)
                        {
                            Console.WriteLine("Input must be a number.");
                            input = Console.ReadLine();
                        }

                    } while (number != -1);

                    Console.WriteLine("Lukujen summa on " + count + ".");
                }
                //Tehtävä 4 valinta
                else if (select == 4)
                {
                    int loop1 = 0;
                    int loop2 = 0;
                    decimal number1 = 0;

                    do
                    {
                        Console.WriteLine("Please input first number:");
                        string input1 = Console.ReadLine();

                        if (decimal.TryParse(input1, out decimal holding1) == true)
                        {
                            number1 = holding1;
                            loop1 = 1;
                            
                        } else
                        {
                            Console.WriteLine("Input must be a number.");
                        }

                    } while (loop1 == 0);

                    do
                    {
                        Console.WriteLine("Please input second number");
                        string input2 = Console.ReadLine();

                        if (decimal.TryParse(input2, out decimal number2) == true)
                        {
                            decimal rounded1 = Math.Round(number1, 2);
                            decimal rounded2 = Math.Round(number2, 2);

                            Console.WriteLine(rounded1.ToString("F") + " + " + rounded2.ToString("F") + " = " + Math.Round(number1 + number2, 2).ToString("F") + "");
                            Console.WriteLine(rounded1.ToString("F") + " - " + rounded2.ToString("F") + " = " + Math.Round(number1 - number2, 2).ToString("F") + "");
                            Console.WriteLine(rounded1.ToString("F") + " x " + rounded2.ToString("F") + " = " + Math.Round(number1 * number2, 2).ToString("F") + "");
                            Console.WriteLine(rounded1.ToString("F") + " / " + rounded2.ToString("F") + " = " + Math.Round(number1 / number2, 2).ToString("F") + "");

                            loop2 = 1;

                        } else
                        {
                            Console.WriteLine("Input must be a number.");
                        }
                    } while (loop2 == 0);

                } else
                { 
                    Console.WriteLine("Invalid selection, please reboot.");
                }
            } else
            {
                Console.WriteLine("Invalid selection, please reboot.");
            }
            
        }
    }
}
