using System;


namespace CRAM
{
    public class Seabird : AAnimal
    {

        // Constructor de major càrrega lògica
        public Seabird(string name, string superFamily, string species, double weight) : base(name, superFamily, species, weight) { }

        // Constructor sense paràmetres 
        public Seabird() : base("Pingu", "Au Marina", "Pingüí", 20) { }

        /// <summary>
        /// Métode que retorna el grau d'afectació després de l'aplicació del tractament
        /// </summary>
        /// <returns>Retorna el grau d'afectació amb la fórmula de la au marina0 depenent si es cura en la localització o es trasllada al CRAM</returns>
        public override int ApplyTreatment(bool onLocation, int GA)
        {
            const int CureOnLocation = 5;

            // Es cambia la fórmula del càlcul respecte a la pràctica ja que dona valors negatius
            return onLocation ? GA - GA + CureOnLocation : GA - GA;
        }


        public override string ToString()
        {

            return "+-------------------------------------------------------------+\n" +
                               "|                       FITXA                                 |\n" +
                               "+-------------------------------------------------------------+\n" +
                               "| # Nom | Superfamília\t\t| Espècie \t| Pes aproximat       |\n" +
                               "+-------------------------------------------------------------+\n" +
                               "| " + Name + " | " + SuperFamily + "\t\t| " + Species + "\t | " + Weight + "kg|\n" +
                               "+-------------------------------------------------------------+";


        }

    }
}
