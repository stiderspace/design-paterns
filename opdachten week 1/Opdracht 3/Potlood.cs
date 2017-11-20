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

        public bool IsScherp => geschrevenKarakters > maxTeSchrijven;

        public void NaGeslepen()
        {
            geschrevenKarakters = 0;
        }

        public void Schrijf(string boodschap)
        {
            char[] chars = boodschap.ToCharArray();

            for( int i = 0; i < maxTeSchrijven; i++)
            {
                System.Console.Write(chars[i]);
            }
            for (int i = maxTeSchrijven; i < chars.Length; i++)
            {
                System.Console.Write('#');
            }
            System.Console.WriteLine();
        }
    }
}