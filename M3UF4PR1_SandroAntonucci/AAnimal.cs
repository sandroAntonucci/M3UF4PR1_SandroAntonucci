using System;


namespace CRAM
{
    public abstract class AAnimal
    {

        const int One = 1, Two = 2, Three = 3;

        public string Name { get; set; }
        public string SuperFamily { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }

        public AAnimal(string name, string superFamily, string species, double weight)
        {
            Name = name;
            SuperFamily = superFamily;
            Species = species;
            Weight = weight;
        }

        /// <summary>
        /// Mètode que genera un animal aleatori i el retorna
        /// </summary>
        /// <returns>Retorna un animal aleatori (o cetaci, o tortuga, o au marina)</returns>
        public static AAnimal GenerateRandomAnimal()
        {
            AAnimal animalToRescue;
            int randomAnimal = GameMethods.GenerateRandom(One,Three);

            switch (randomAnimal)
            {
                case One:
                    animalToRescue = new Seabird();
                    break;
                case Two:
                    animalToRescue = new Cetacean();
                    break;
                default:
                    animalToRescue = new Turtle();
                    break;
            }

            return animalToRescue;

        }

        public abstract int ApplyTreatment(bool onLocation, int GA);

    }
}
