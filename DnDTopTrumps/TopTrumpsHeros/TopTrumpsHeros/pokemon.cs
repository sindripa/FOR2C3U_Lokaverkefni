using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTrumpsDnD
{
    public class pokemon: Bass
    {
        public pokemon(string tipa, double hp, double ad, double def, double s_ad, double s_def, double sp)
            : base(tipa, new double[] { hp, ad, def, s_ad, s_def, sp}, new string[] { "Hp", "Attack", "Defense", "Special attack", "Special defense", "Speed" })
        {
        }
    }
}
