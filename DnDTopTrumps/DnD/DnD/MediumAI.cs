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
        public override string ToString()
        {
            return "Medium";
        }

        //þetta er það sem lætur tölvuna velja
        public override int AI(Bass dude)
        {
            Random random = new Random();
            return random.Next(0, Average.Length);//velur random tölu
        }

        /*redundant constructor*/
        public MediumAI(double[] avgStats)
            :base(avgStats)
        {

        }
    }
}
