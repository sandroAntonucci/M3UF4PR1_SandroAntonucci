using System;

namespace CRAM
{
    public class Rescue
    {

        const int MinGA = 0, MinRES = 0, MaxGA = 100, MaxRES = 1000, MinLocation = 0, MaxLocation = 4;
        public string NRescue { get; set; }

        public DateTime Date { get; set; }

        public string Species { get; set; }

        public int GA { get; set; }

        public string Location { get; set; }

        public Rescue(string nRescue, DateTime date, string species, int gA, string location)
        {
            NRescue = nRescue;
            Date = date;
            Species = species;
            GA = gA;
            Location = location;
        }

        // Si només s'introdueix la superfamília, es generen els altres camps aleatòriament
        public Rescue(string species) 
        {
            NRescue = GenerateResNum();
            Date = DateTime.Now;
            Species = species;
            GA = GenerateGA();
            Location = GenerateLocation();
        }


        /// <summary>
        /// Mètode que retorna un número de rescat aleatori entre 0 i 999 (inclosos)
        /// </summary>
        /// <returns>Retorna el número de rescat generat</returns>
        public string GenerateResNum()
        {
            Random random = new Random();
            return "RES" + random.Next(MinRES, MaxRES);
        }

        /// <summary>
        /// Mètode que retorna un grau d'afectació aleatori entre 1 i 100 (inclosos)
        /// </summary>
        /// <returns>Retorna el grau d'afectació generat</returns>
        public int GenerateGA()
        {
            Random random = new Random();
            return random.Next(MinGA, MaxGA);
        }

        /// <summary>
        /// Mètode que retorna una localització aleatòria entre Barcelona, Girona, Lleida i Tarragona
        /// </summary>
        /// <returns>Retorna una localització aleatòria</returns>
        public string GenerateLocation()
        {
            string[] Cities = { "Barcelona", "Girona", "Lleida", "Tarragona" };
            Random random = new Random();
            return Cities[random.Next(MinLocation, MaxLocation)];
        }



        public override string ToString()
        {

            return $"+-------------------------------------------------------------+\n" +
                   $"|                       RESCAT                                |\n" +
                   $"+-------------------------------------------------------------+\n" +
                   $"| # Rescat | Data rescat | Espècie \t\t| GA | Localització|\n" +
                   $"+-------------------------------------------------------------+\n" +
                   $"| {NRescue}   | {Date}  | {Species} \t\t| {GA} | {Location}|\n" +
                   $"+-------------------------------------------------------------+";

        }
    }
}
