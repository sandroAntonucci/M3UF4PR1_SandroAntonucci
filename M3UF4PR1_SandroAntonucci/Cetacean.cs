using System;


namespace CRAM
{
    public class Cetacean : AAnimal
    {

        const string BaseName = "Oumou";
        const string BaseSuperFamily = "Cetaci";
        const string BaseSpecies = "Dofí";
        const double BaseWeight = 20.5;
        

        // Constructor de major càrrega lògica
        public Cetacean(string name, string superFamily, string species, double weight) : base(name, superFamily, species, weight) { }

        // Constructor sense paràmetres 
        public Cetacean() : base(BaseName, BaseSuperFamily, BaseSpecies, BaseWeight) { }

        /// <summary>
        /// Métode que retorna el grau d'afectació després de l'aplicació del tractament
        /// </summary>
        /// <returns>Retorna el grau d'afectació amb la fórmula del cetaci depenent si es cura en la localització o es trasllada al CRAM</returns>
        public override int ApplyTreatment(bool onLocation, int GA)
        {
            const int CureOnLocation = 25;
            return onLocation ? GA - Convert.ToInt32((Math.Log10(GA))) - CureOnLocation : GA - Convert.ToInt32((Math.Log10(GA)));
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
