using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours3
{
    public class PotionForce
    {
        private int ForceAugm;

        public PotionForce()
        {
            this.ForceAugm = 20;
        }

        public void applyeffect(Player player)
        {
            player.addFor(ForceAugm);
        }
    }
}
