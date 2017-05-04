using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTrumpsDnD;

namespace DnD
{
    class ArtificialBot
    {
        private double[] average;
        public double[] Average
        {
            get
            {
                return average;
            }
            set
            {
                average = value;
            }
        }

        public ArtificialBot(double[] avgStats)
        {
            Average = avgStats;
        }

    }
}
