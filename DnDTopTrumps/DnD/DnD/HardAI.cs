﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTrumpsDnD;

namespace DnD
{
    class HardAI : ArtificialBot
    {

        public override string ToString()
        {
            return "Hard";
        }

        //þetta er það sem lætur tölvuna velja
        public override int AI(Bass dude)
        {
            double[] Shift = new double[Average.Length];
            for (int i = 0; i < Average.Length; i++)
            {
                Shift[i] = dude.Stats[i] / Average[i];
            }
            for (int i = 0; i < Average.Length; i++)
            {
                if (Shift[i] == Shift.Max())//velur hærstu töluna
                {
                    return i;
                }
            }
            return 1;
        }

        public HardAI(double[] avgStats)
            :base(avgStats)
        {

        }
    }
}
