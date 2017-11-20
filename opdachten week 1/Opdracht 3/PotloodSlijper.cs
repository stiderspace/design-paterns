namespace Opdracht_3
{
    internal class PotloodSlijper : IPotloodSlijper
    {
        public void Slijp(IPotlood potlood)
        {
            potlood.NaGeslepen();
        }
    }
}