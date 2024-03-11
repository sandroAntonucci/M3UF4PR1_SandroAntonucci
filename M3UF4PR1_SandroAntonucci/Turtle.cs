using System;


namespace CRAM
{
    public class Turtle : AAnimal
    {

        const string BaseName = "Valpa";
        const string BaseSuperFamily = "Tortuga marina";
        const string BaseSpecies = "Tortuga Careta";
        const double BaseWeight = 7;

        // Constructor de major càrrega lògica
        public Turtle(string name, string superFamily, string species, double weight) : base(name, superFamily, species, weight) { }

        // Constructor sense paràmetres 
        public Turtle() : base(BaseName, BaseSuperFamily, BaseSpecies, BaseWeight) { }

        /// <summary>
        /// Métode que retorna el grau d'afectació després de l'aplicació del tractament
        /// </summary>
        /// <returns>Retorna el grau d'afectació amb la fórmula de la tortuga depenent si es cura en la localització o es trasllada al CRAM</returns>
        public override int ApplyTreatment(bool onLocation, int GA)
        {
            const int Cure = 5, Three = 3;

            // Es cambia la fórmula del càlcul respecte a la pràctica ja que dona valors incorrectes
            return onLocation ? GA - GA / Three - Cure : GA - GA / Three;
        }

        public override string ToString()
        {

            return "+-------------------------------------------------------------+\n" +
                                "|                       FITXA                                 |\n" +
                                "+-------------------------------------------------------------+\n" +
                                "| # Nom | Superfamília\t\t| Espècie \t| Pes aproximat       |\n" +
                                "+-------------------------------------------------------------+\n" +
                                "| " + Name + " | " + SuperFamily + "\t| " + Species + "\t | " + Weight + "kg|\n" +
                                "+-------------------------------------------------------------+";
        }

    }
}