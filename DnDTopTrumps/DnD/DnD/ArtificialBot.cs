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
        public override string ToString()
        {
            return "Error";
        }
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

        //þetta er það sem lætur tölvuna velja
        public virtual int AI(Bass dude)
        {
            return 1;
        }

        public ArtificialBot(double[] avgStats)
        {
            Average = avgStats;
        }

    }
}
