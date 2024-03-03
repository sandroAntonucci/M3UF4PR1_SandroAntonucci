using System;

namespace CRAM
{
    public class Player
    {

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
            if (roleType == 1) RewardXP = 45;
            else if (roleType == 2) RewardXP = 80; 

            XP = 0;
        }

    }
}
