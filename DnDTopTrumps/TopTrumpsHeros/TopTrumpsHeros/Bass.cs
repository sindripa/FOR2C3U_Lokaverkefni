using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTrumpsDnD
{
    public class Bass//52 spil, 8 flokkar
    {
        public string Tipa { get; private set; }
        public short ArmourClass { get; private set; }
        public short HitPoints { get; private set; }
        public short Strength { get; private set; }
        public short Intelligence { get; private set; }
        public short Dexterity { get; private set; }
        public short Wistom { get; private set; }
        public short Constitution { get; private set; }
        public short Charisma { get; private set; }
        public short[] Stats = new short[8];
        public Bass(string tipa,short ac, short hp, short str,  short dex, short con, short intel, short wis, short cha)
        {
            Tipa = tipa;
            ArmourClass = ac;
            Stats[0] = ac;
            HitPoints = hp;
            Stats[1] = hp;
            Strength = str;
            Stats[2] = str;
            Dexterity = dex;
            Stats[3] = dex;
            Constitution = con;
            Stats[4] = con;
            Intelligence = intel;
            Stats[5] = intel;
            Wistom = wis;
            Stats[6] = wis;
            Charisma = cha;
            Stats[7] = cha;
        }
        public override string ToString()
        {
            return Tipa  + "\nArmour Class: " + ArmourClass+ "\nMax Health: " + HitPoints + "\nStrength: " + Strength + "\nDexterity: " + Dexterity + "\nConstitution: " + Constitution + "\nIntelligence: " + Intelligence + "\nWistom: " + Wistom + "\nCharisma: " + Charisma;
        }
    }
    public class Player : Bass
    {
        public string Nafn { get; set; }
        public string Role { get; set; }
        public Player(string nafn,string role,string tipa, short ac, short hp, short str, short dex, short con, short intel, short wis, short cha)
            : base(tipa, ac, hp, str, dex, con, intel, wis, cha)
        {
            Nafn = nafn;
            Role = role;
        }
        public override string ToString()
        {
            return Nafn+" - "+Role+": "+base.ToString();
        }
    }
    public class stockurDnD
    {
        public List<Player> stockur = new List<Player>();
        public Player[] stockurinn = {  new Player("LightNir", "Rogue/arcane trickster", "Half elf", 14, 13, 12, 17, 10, 16, 12, 10),
                                        new Player("NoLeb", "Druid/Circle of Land", "Human", 10, 15, 17, 9, 13, 13, 17, 10),
                                        new Player("Sindri Páls", "Cleric", "Human", 10, 10, 10, 8, 12, 13, 10, 6),
                                        new Player("Snorri", "Teacher", "Human", 11, 15, 11, 11, 11, 14, 13, 10),
                                        new Player("Aldrid The Imputent", "Sorcerer", "Ogre", 11, 10, 14, 12, 7, 17, 14, 4),
                                        new Player("Hugombo", "Tank/rock smasher", "Ogre", 14, 18, 19, 10, 14, 5, 6, 4),
                                        new Player("Nizerus", "Rogue/assasin", "gnome", 16, 8, 9, 18, 7, 14, 12, 12),
                                        new Player("Melona", "Rogue/thief", "Human", 14, 9, 9, 16, 8, 14, 15, 16),
                                        new Player("Bart", "Bard/support", "Dwarf", 13, 15, 12, 10, 13, 14, 15, 16),
                                        new Player("Ombinotus", "Paladin", "Half elf", 15, 18, 14, 10, 16, 17, 13, 14),
                                        new Player("Hercumes", "Barbarian", "Orc", 13, 10, 20, 16, 9, 10, 12, 11),
                                        new Player("Ariana", "Ranger/hunter", "Hafling", 14, 7, 8, 17, 8, 13, 14, 12),
                                        new Player("Amotabono", "Swordsman", "Human", 15, 10, 16, 16, 12, 13, 14, 11),
                                        new Player("Brock O. Lee", "Monk", "Human", 16, 14, 15, 17, 12, 10, 13, 10),
                                        new Player("Charaka", "Magie", "Elf", 8, 7, 10, 7, 8, 18, 17, 16),
                                        new Player("DANK MEME", "bard", "Abomination", 1, 1, 10, 1, 1, 16, 12, 16),
                                        new Player("Romfus", "Druid", "Dwarf", 14, 12, 14, 13, 12, 13, 14, 12),
                                        new Player("Dracius", "Wizard", "Dragonborn", 13, 11, 11, 9, 11, 20, 16, 12),
                                        new Player("Brockus", "Cleric", "Half Orc", 16, 12, 14, 9, 14, 12, 12, 13),
                                        new Player("Penriany", "Sorcerer", "Gnome", 14, 9, 7, 16, 8, 16, 15, 14),
                                        new Player("Trunk", "Barbarian", "Gnome", 18, 17, 15, 14, 17, 7, 8, 9),
                                        new Player("GurKursckar", "Warlock", "Orc", 10, 11, 10, 10, 11, 17, 18, 10),
                                        new Player("Scruff", "Rogue", "Goblin", 17, 6, 13, 20, 7, 8, 11, 7),
                                        new Player("Jama", "Wizard", "Elf", 8, 8, 9, 8, 8, 18, 18, 15),
                                        new Player("IckSan", "Monk", "Halfling", 14, 11, 14, 15, 11, 10, 11, 15),
                                        new Player("Hexicon", "Lich", "Tiefling", 12, 8, 12, 4, 10, 17, 13, 16),
                                        new Player("Hocraha", "Fighter", "Dragonborn", 14, 15, 14, 12, 12, 13, 16, 14),
                                        new Player("Jesus Crist", "Bard", "Half Elf", 12, 10, 10, 13, 11, 15, 15, 20),
                                        new Player("Troom", "Druid", "Halfling", 14, 12, 14, 18, 12, 12, 12, 5),
                                        new Player("Daby", "Cleric", "Dwarf", 15, 14, 14, 6, 13, 15, 12, 12),
                                        new Player("Lingur", "Wizard", "Elf", 11, 8, 7, 12, 7, 18, 15, 7),
                                        new Player("Vermona", "Bard", "Human", 10, 9, 10, 10, 7, 13, 12, 14),
                                        new Player("Sigurður Orri Hjalta", "Monk", "Human", 12, 8, 10, 13, 9, 13, 12, 7),
                                        new Player("Holly", "Sorcerer", "Tiefling", 10, 11, 11, 12, 14, 14, 16, 13),
                                        new Player("Ama'croh", "Fighter", "Dragonborn", 15, 17, 17, 13, 17, 14, 13, 8),
                                        new Player("Policom", "Ranger", "Half Elf", 14, 12, 7, 16, 7, 13, 13, 12),
                                        new Player("HoKing", "Wizard", "Elf", 4, 5, 3, 3, 8, 20, 20, 14),
                                        new Player("Malkoa", "Monk", "Half Elf", 15, 15, 14, 15, 14, 10, 15, 10),
                                        new Player("Boraka", "Barbarion", "Half Ork", 8, 16, 15, 7, 16, 7, 8, 14),
                                        new Player("Alibok", "Druid", "Half Orc", 11, 13, 14, 14, 12, 13, 16, 7),
                                        new Player("Zena", "Paladin", "Tiefling", 18, 18, 13, 7, 18, 17, 13, 15),
                                        new Player("Dinean", "Ranger", "Halfling", 16, 9, 10, 18, 9, 12, 16, 14),
                                        new Player("Jain", "Wizard", "Human", 12, 10, 8, 13, 10, 17, 16, 15),
                                        new Player("Glandin", "Warlock", "Dwarf", 12, 13, 12, 11, 13, 17, 17, 15),
                                        new Player("Evana", "Warlock", "Halfling", 14, 10, 9, 16, 11, 14, 14, 17),
                                        new Player("Mina", "Fighter", "Dwarf", 16, 16, 16, 7, 16, 8, 13, 16),
                                        new Player("Udi", "Druid", "Half Orc", 12, 12, 8, 13, 14, 13, 15, 13),
                                        new Player("Reachy", "Fighter", "Gnome", 16, 13, 16, 13, 14, 8, 13, 15),
                                        new Player("Tari'con", "cleric", "Dragonborn", 16, 16, 13, 12, 14, 16, 16, 15),
                                        new Player("Quoro", "Fighter", "Orc", 12, 15, 18, 10, 16, 7, 9, 8),
                                        new Player("Slashon", "Rogue", "Human", 15, 10, 10, 18, 11, 12, 11, 13),
                                        new Player("Hance", "Cleric", "Half Orc", 18, 9, 10, 7, 9, 17, 15, 15)
                                     };
        public double AcAvg
        {
            get
            {
                int[] st = new int[52];
                for (int i = 0; i < stockur.Count; i++)
                {
                    st[i] = stockur[i].ArmourClass;
                }
                return st.Average();
            }
        }
        public double HpAvg
        {
            get
            {
                int[] st = new int[52];
                for (int i = 0; i < stockur.Count; i++)
                {
                    st[i] = stockur[i].HitPoints;
                }
                return st.Average();
            }
        }
        public double StrAvg
        {
            get
            {
                int[] st = new int[52];
                for (int i = 0; i < stockur.Count; i++)
                {
                    st[i] = stockur[i].Strength;
                }
                return st.Average();
            }
        }
        public double DexAvg
        {
            get
            {
                int[] st = new int[52];
                for (int i = 0; i < stockur.Count; i++)
                {
                    st[i] = stockur[i].Dexterity;
                }
                return st.Average();
            }
        }
        public double ConAvg
        {
            get
            {
                int[] st = new int[52];
                for (int i = 0; i < stockur.Count; i++)
                {
                    st[i] = stockur[i].Constitution;
                }
                return st.Average();
            }
        }
        public double IntAvg
        {
            get
            {
                int[] st = new int[52];
                for (int i = 0; i < stockur.Count; i++)
                {
                    st[i] = stockur[i].Intelligence;
                }
                return st.Average();
            }
        }
        public double WisAvg
        {
            get
            {
                int[] st = new int[52];
                for (int i = 0; i < stockur.Count; i++)
                {
                    st[i] = stockur[i].Wistom;
                }
                return st.Average();
            }
        }
        public double ChaAvg
        {
            get
            {
                int[] st = new int[52];
                for (int i = 0; i < stockur.Count; i++)
                {
                    st[i] = stockur[i].Charisma;
                }
                return st.Average();
            }
        }
        public double[] StatsAvg = new double[8];
        public stockurDnD()
        {
            for (int i = 0; i < 52; i++)
            {
                stockur.Add(stockurinn[i]);
                StatsAvg[0] = AcAvg;
                StatsAvg[1] = HpAvg;
                StatsAvg[2] = StrAvg;
                StatsAvg[3] = DexAvg;
                StatsAvg[4] = ConAvg;
                StatsAvg[5] = IntAvg;
                StatsAvg[6] = WisAvg;
                StatsAvg[7] = ChaAvg;
            }
        }
    }
}
