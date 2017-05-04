using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTrumpsDnD;

namespace DnD
{
    class MediumAI : ArtificialBot
    {
        public int AI()
        {
            Random random = new Random();
            return random.Next(0, Average.Length);
        }

        /*redundant constructor*/
        public MediumAI(double[] avgStats)
            :base(avgStats)
        {

        }
    }
}
