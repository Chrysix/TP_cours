using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            PotionSoin potion1 = new PotionSoin();
            PotionForce potion2 = new PotionForce();

            player.presentPV();
            player.presentFor();

            player.drinkPotion(potion1);
            player.drinkPotion(potion2);

            player.presentPV();
            player.presentFor();


        }
    }
}
