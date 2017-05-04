using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTrumpsDnD
{
    public class Bass//52 spil, mmissmunadni fjöldi stata
    {
        public string Tipa;
        public double[] Stats;
        public string[] StatsName;
        public Bass(string tipa, double[] stats, string[] statsName)
        {
            Tipa = tipa;
            StatsName = statsName;
            Stats = stats;
        }
        public override string ToString()
        {
            string lysing = Tipa;
            for (int i = 0; i < Stats.Length; i++)//aðal upplysingar
			{
                lysing += "\n" + Stats[i] + ":\t" + StatsName[i];
			}
            return lysing;
        }
    }
    
}
