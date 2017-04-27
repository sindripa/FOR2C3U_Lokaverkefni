using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTrumpsDnD
{

    public class Player : Bass
    {
        public string Nafn { get; set; }
        public string Role { get; set; }
        public Player(string nafn, string role, string tipa, double ac, double hp, double str, double dex, double con, double intel, double wis, double cha)
            : base(tipa, new double[] { ac, hp, str, dex, con, intel, wis, cha }, new string[] { "Armor Class", "Hit Points", "Strength", "Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma" })
        {
            Nafn = nafn;
            Role = role;
        }
        public override string ToString()
        {
            return Nafn + " - " + Role + ": " + base.ToString();
        }
    }
}
