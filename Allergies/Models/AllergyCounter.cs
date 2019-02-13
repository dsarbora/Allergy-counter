using System;

namespace Allergies.Models
{
    class AllergyCounter
    {
        private int AllergyCount;
        private string[] yourAllergies= {
            "eggs",
            "peanuts",
            "shellfish",
            "strawberries",
            "tomatoes",
            "chocolate",
            "pollen",
            "cats"
            };

        public AllergyCounter(int allergyCount)
        {
            AllergyCount = allergyCount;
        }

        public int GetAllergyCount()
        {
            return AllergyCount;
        }

        public void DetermineAllergies()
        {
            Console.WriteLine("You are allergic to:");
            while(AllergyCount>0)
            {
                int i = 0;
                int current = 1;
                if(AllergyCount>1)
                {
                    while(AllergyCount>=current)
                    {
                        current += current;
                        ++i;
                    }
                    AllergyCount -=(current/2);
                    Console.WriteLine(yourAllergies[i-1]);
                }
                else
                {
                    Console.WriteLine(yourAllergies[0]);
                    AllergyCount --;
                }
            }
        
        }
        public int GetNumber(string input)
        {
            int current = 1;
            for (int i = 0; i<=yourAllergies.GetUpperBound(0); i++)
            {
                if(input == yourAllergies[i])
                {
                    AllergyCount += current;
                }
                else
                {
                    current += current;
                }
            }
            Console.WriteLine("Is there anything else?(Y/N)");
            string response = Console.ReadLine().ToLower();
            if(response == "y")
            {
                Console.WriteLine("What is it?");
                string newAllergy = Console.ReadLine().ToLower();
                this.GetNumber(newAllergy);
            }
            return AllergyCount;
        }
    }
}