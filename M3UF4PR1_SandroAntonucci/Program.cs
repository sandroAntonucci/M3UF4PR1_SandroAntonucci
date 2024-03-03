using System;

// Clase base para los animales

namespace CRAM
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            const int One = 1, Five = 5, Twenty = 20;

            const string MsgEndGame = "Fins el proper rescat!";
            const string MsgShowMenu = "1. Jugar\n2. Sortir\n\nAcció: ";
            const string MsgInvalidAction = "Aquesta acció no és vàlida.";
            const string MsgValidMenuAction = "Perfecte!";
            const string MsgShowRoles = "Què vols ser? \n\n1.Tècnic(45 XP)\n2.Veterinari(80 XP)\n\nAcció: ";
            const string MsgIntroName = "Genial! I el teu nom?";
            const string MsgRescue = "Hola, {0}! El 112 ha rebut una trucada d'avís d'un exemplar a rescatar.\nLes dades que ens han donat són les següents: ";
            const string MsgFile = "Aquí tens la seva fitxa, per a més informació: ";
            const string MsgAffectation = "El/la {0} te´un grau d'afectació (GA) del {1}%.\nVols fer la cura aquí (1) o traslladar l'animal al centre (2)?\n\n";
            const string MsgGAReduction = "El grau d'afectació després de l'aplicació del tractament és de {0}%.";
            const string MsgNotRecovered = "L'animal no s'ha recuperat correctament. Perds 20 d'experiència.";
            const string MsgRecovered = "L'animal s'ha recuperat correctament. Guanyes {0} d'experiència.";
            const string MsgFinalXP = "La teva experiència final és de {0}.";

            int userAction = 0, userCureChoice, randomAnimal;
            AAnimal animalToRescue;      

            // Menu
            do
            {
                Console.Write(MsgShowMenu);
                userAction = Convert.ToInt32(Console.ReadLine());

                if (!CheckValidAction(userAction)) Console.WriteLine(MsgInvalidAction);
            
            }while(!CheckValidAction(userAction));

            // Si l'usuari vol jugar
            if(userAction == 1)
            {

                // Es genera un animal aleatori
                animalToRescue = GenerateRandomAnimal();

                Console.Write(MsgValidMenuAction);

                // Elecció de rol
                do
                {
                    Console.Write(MsgShowRoles);
                    userAction = Convert.ToInt32(Console.ReadLine());

                    if (!CheckValidAction(userAction)) Console.WriteLine(MsgInvalidAction);

                } while (!CheckValidAction(userAction));

                // S'introdueix el nom i es crea el jugador (no es comprova res del nom, tots són vàlids)
                Console.WriteLine(MsgIntroName);
                Player player = new Player(Console.ReadLine(), userAction);

                Console.WriteLine(MsgRescue, player.Name);

                // Es genera un rescat i s'informa al jugador de les dades
                Rescue rescue = new Rescue(animalToRescue.SuperFamily);
                Console.WriteLine(rescue.ToString());
                Console.WriteLine(MsgFile);
                Console.WriteLine(animalToRescue.ToString());

                // Elecció de tractament (no surt del bucle fins que no introdueix un valor vàlid)
                do
                {
                    Console.WriteLine(MsgAffectation, animalToRescue.Species, rescue.GA);
                    userCureChoice = Convert.ToInt32(Console.ReadLine());

                    if (!CheckValidAction(userCureChoice)) Console.WriteLine(MsgInvalidAction);

                } while (!CheckValidAction(userCureChoice));
                
                rescue.GA = animalToRescue.ApplyTreatment(userCureChoice == One, rescue.GA);

                Console.WriteLine(MsgGAReduction, rescue.GA);
                Console.ReadKey();

                // Es comprova si l'animal no s'ha recuperat (més del 5 percent de grau d'afectació)
                if(rescue.GA > Five)
                {
                    Console.WriteLine(MsgNotRecovered);

                    // Es resta 20 d'experiència al jugador
                    player.XP -= Twenty;
                }
                else
                {
                    Console.WriteLine(MsgRecovered, player.RewardXP);

                    // Es suma l'experiència al jugador depenent del seu rol (aixó es declara al constructor)
                    player.XP += player.RewardXP;
                }

                Console.WriteLine(MsgFinalXP, player.XP);
                
                Console.ReadKey();
            }

            Console.WriteLine(MsgEndGame);

        }

        /// <summary>
        /// Mètode que retorna si l'acció es vàlida
        /// </summary>
        /// <param name="upper">Si action és igual a 1 o 2 retorna true, si no false</param>
        /// <returns>Retorna si action és igual a 1 o 2</returns>
        public static bool CheckValidAction(int action)
        {
            return action == 1 || action == 2;
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
            return random.Next(min, max+1);
        }

         
        /// <summary>
        /// Mètode que genera un animal aleatori i el retorna
        /// </summary>
        /// <returns>Retorna un animal aleatori (o cetaci, o tortuga, o au marina)</returns>
        public static AAnimal GenerateRandomAnimal()
        {
            AAnimal animalToRescue;
            int randomAnimal = GenerateRandom(1, 3);

            if (randomAnimal == 1)
            {
                animalToRescue = new Turtle();
            }
            else if (randomAnimal == 2)
            {
                animalToRescue = new Cetacean();
            }
            else
            {
                animalToRescue = new Seabird();
            }

            return animalToRescue;
        }



    }

}
