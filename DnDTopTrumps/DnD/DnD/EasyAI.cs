using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTrumpsDnD;

namespace DnD
{
    class EasyAI : ArtificialBot
    {

        public int AI(Bass dude)
        {
            double[] Shift = new double[Average.Length];
            for (int i = 0; i < Average.Length; i++)
            {
                Shift[i] = dude.Stats[i] / Average[i];
            }
            for (int i = 0; i < Average.Length; i++)
            {
                if (Shift[i] == Shift.Min())
                {
                    return i;
                }
            }
            return 1;
        }

        public EasyAI(double[] avgStats)
            : base(avgStats)
        {

        }
    }
}
