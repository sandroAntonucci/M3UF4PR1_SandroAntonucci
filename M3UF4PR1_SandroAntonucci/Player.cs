using System;

namespace CRAM
{
    public class Player
    {

        const int Zero = 0, Technical = 1, Veterinarian = 2, TechnicalXP = 45, VeterinarianXP = 80;

        public string Name { get; set; }
        public int RewardXP { get; set; }
        public int XP { get; set; }


        public Player(string name, int rewardXP, int xp) 
        { 
            Name = name;
            RewardXP = rewardXP;
            XP = xp;
        }

        public Player(string name, int roleType)
        {
            Name = name;

            // El roletype ens indica si es técnic o veterinari i s'assignen les recompenses d'XP depenent del rol
            if (roleType == Technical) RewardXP = TechnicalXP;
            else if (roleType == Veterinarian) RewardXP = VeterinarianXP; 

            XP = Zero;
        }

    }
}
