using System;

namespace Test_try_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                // Vraag om kleur
                Console.WriteLine("Hoi, welke kleur wil je dat de console wordt? (groen/rood/anders)");

                // Sla kleur op
                string kleur = Console.ReadLine()?.ToLower();

                if (kleur == "stop")
                {
                    break;
                }
                // Controleer de invoer en pas de kleur aan
                // als kleur is groen, maak console groen
                // als kleur is rood, maak console groen
                // als kleur is niet rood of groen, maak console paars
                if (kleur == "groen" || kleur == "green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (kleur == "rood" || kleur == "red")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (kleur == "geel" || kleur == "yellow")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (kleur == "blauw" || kleur == "blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (kleur == "wit" || kleur == "white")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (kleur == "zwart" || kleur == "black")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }

                Console.WriteLine("/help" + kleur);  

                //change werkt?
            }

        }
       
    }

}
