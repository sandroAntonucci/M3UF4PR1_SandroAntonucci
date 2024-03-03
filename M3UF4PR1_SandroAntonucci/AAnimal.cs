using System;


namespace CRAM
{
    public abstract class AAnimal
    {
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

        public abstract int ApplyTreatment(bool onLocation, int GA);

    }
}
