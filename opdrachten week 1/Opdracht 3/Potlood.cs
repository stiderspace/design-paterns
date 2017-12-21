using System;

namespace Opdracht_3
{
    internal class Potlood : IPotlood
    {
        private int maxTeSchrijven;

        private int geschrevenKarakters;
        // aantal reeds geschreven karakters
        public Potlood(int max)
        {
            maxTeSchrijven = max;
        }

        public bool IsScherp => geschrevenKarakters < maxTeSchrijven;

        public void NaGeslepen()
        {
            geschrevenKarakters = 0;
        }

        public void Schrijf(string boodschap)
        {
            char[] chars = boodschap.ToCharArray();

            foreach(char character in chars)
            {
                if(IsScherp)
                {
                    Console.Write(character);
                    geschrevenKarakters++;
                }
                else
                {
                    Console.Write('#');
                }
            }
            Console.WriteLine();
        }
    }
}