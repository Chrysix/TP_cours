using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours3
{
    public class Player
    {
        private int pv;
        private int force;

        public Player()
        {
            this.pv = 100;
            this.force = 100;
        }

        public void presentPV()
        {
            Console.WriteLine("Player PV : " + pv);
           
        }

        public void presentFor()
        {
            Console.WriteLine("Player Force : " + force);

        }


        public void addPV(int pv)
        {
            this.pv += pv;
        }

        public void addFor(int force)
        {
            this.force += force;
        }

        public void drinkPotion(PotionSoin potion)
        {
            potion.applyeffect(this);
        }



        
        public void drinkPotion(PotionForce potion)
        {
            potion.applyeffect(this);
        }
    }
}
