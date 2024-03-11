using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAM
{
    public static class GameMethods
    {

        const int One = 1, Two = 2; 

        /// <summary>
        /// Mètode que retorna si l'acció es vàlida
        /// </summary>
        /// <param name="upper">Si action és igual a 1 o 2 retorna true, si no false</param>
        /// <returns>Retorna si action és igual a 1 o 2</returns>
        public static bool CheckValidAction(int action)
        {
            return action == One || action == Two;
        }

        /// <summary>
        /// Mètode que retorna un valor aleatori entre min i max
        /// </summary>
        /// <param name="min">Valor mínim</param>
        /// <param name="max">Valor màxim</param>
        /// <returns>Retorna un valor aleatori entre min i max (inclosos)</returns>
        public static int GenerateRandom(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + One);
        }

    }
}
