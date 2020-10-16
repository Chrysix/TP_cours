using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours3
{
    public class PotionSoin
    {
        private int PvRendu;

        public PotionSoin()
        {
            this.PvRendu = 10;
        }

        public void applyeffect(Player player)
        {
            player.addPV(PvRendu);
        }
    }
}
