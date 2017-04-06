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
        public Bass(string tipa,short ac, short hp, short str,  short dex, short con, short intel, short wis, short cha)
        {
            Tipa = tipa;
            ArmourClass = ac;
            HitPoints = hp;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            Wistom = wis;
            Constitution = con;
            Charisma = cha;
        }
        public override string ToString()
        {
            return Tipa + "\nMax Health: " + HitPoints + "\nArmour Class: " + ArmourClass + "\nStrength: " + Strength + "\nDexterity: " + Dexterity + "\nConstitution: " + Constitution + "\nIntelligence: " + Intelligence + "\nWistom: " + Wistom + "\nCharisma: " + Charisma;
        }
    }
    public class Player : Bass
    {
        public string Nafn { get; set; }
        public string Role { get; set; }
        public Player(string nafn,string role,string tipa, short ac, short hp, short str, short dex, short con, short intel, short wis, short cha)
            : base(tipa, ac, hp, str, intel, dex, wis, con, cha)
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
        public Player[] stockurinn = {  new Player("LightNir", "Rogue/arcane trickster", "Half elf", 14, 13, 12, 17, 10, 16, 12, 10),
                                        new Player("NoLeb", "Druid/Circle of Land", "Human", 10, 15, 17, 9, 13, 13, 17, 10),
                                        new Player("Sigurður Orri Hjalta", "just some dude", "Human", 12, 8, 10, 13, 9, 13, 9, 7),
                                        new Player("Sindri Páls", "just a nother dude", "Human, I think", 10, 10, 10, 8, 12, 13, 10, 6),
                                        new Player("Snorri", "Teacher", "Human", 11, 15, 11, 11, 11, 14, 13, 10),
                                        new Player("Aldrid The Imputent", "Caster", "goblin", 11, 10, 6, 12, 7, 16, 14, 4),
                                        new Player("Hugombo", "Tank/rock smasher", "Ogre", 14, 18, 19, 10, 14, 5, 6, 4),
                                        new Player("Nizerus", "Rouge/assasin", "gnome", 16, 8, 9, 18, 7, 14, 12, 12),
                                        new Player("Melona", "Rouge/thief", "Human", 14, 9, 9, 16, 8, 14, 15, 16),
                                        new Player("Bart", "Bard/support", "Dwarf", 13, 15, 12, 10, 13, 14, 15, 16),
                                        new Player("Ombinotus", "Paladin", "Half elf", 15, 18, 14, 10, 16, 17, 13, 14),
                                        new Player("Hercumes", "Barbarian", "Orc", 13, 10, 20, 16, 9, 10, 12, 11),
                                        new Player("Ariana", "Ranger/hunter", "hafling", 14, 7, 8, 17, 8, 13, 14, 12),
                                        new Player("Amotabono", "Swordsman", "Human", 15, 10, 16, 16, 12, 13, 14, 11),
                                        new Player("Brock O. Lee", "Monk", "Human", 14, 14, 15, 15, 12, 10, 13, 10),
                                        new Player("Charaka", "Magie", "Elf", 8, 7, 10, 7, 8, 18, 17, 16),
                                        new Player("DANK MEME", "bard", "Abomination", 1, 1, 10, 1, 1, 12, 12, 12),
                                        new Player("Romfus", "Druid", "Dwarf", 14, 12, 14, 13, 12, 13, 14, 12),
                                        new Player("Dracius", "Wizard", "Dragonite", 13, 11, 11, 9, 11, 20, 16, 12),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , ),
                                        new Player("", "", "", , , , , , , , )
                                     
                                     };
    }
}
