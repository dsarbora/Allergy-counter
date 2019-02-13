using System;
using Allergies.Models;

namespace Allergies
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Do you want to feed me numbers or words? (NUMBERS or WORDS)");
            string response = Console.ReadLine().ToLower();
            if (response == "words")
            {
                AllergyCounter myAllergyCounter = new AllergyCounter(0);
                Console.WriteLine("Ok, tell me what you're allergic to and I'll calculate the number");
                string allergy = Console.ReadLine().ToLower();
                Console.WriteLine(myAllergyCounter.GetNumber(allergy));
            }
            else{
                Console.WriteLine("Let's play numbers. Give me a number and I'll tell you what you're allergic to.");
                int input = int.Parse(Console.ReadLine());
                AllergyCounter myAllergyCounter = new AllergyCounter(input);
                myAllergyCounter.DetermineAllergies();
            }
            
            
        }
    }
}