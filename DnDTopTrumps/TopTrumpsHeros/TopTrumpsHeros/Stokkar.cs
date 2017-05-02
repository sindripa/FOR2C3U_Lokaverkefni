using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTrumpsDnD
{
    public class stokkurDnD
    {
        public string Reglur//allar reglur
        {
            get
            {
                return "Any number of people can play Top Trumps, that’s what makes it the world’s coolest card game! Here are instructions on how to play Top Trumps. To start the game, shuffle and deal all the cards face down. Each player holds their cards so that they can see the top card only. The player to the dealer’s left starts by reading out a category from the top card (e.g. Height, value 5) The other players then read out the same category from their cards. The one with the best or highest value wins, and that player collects all the top cards, including their own, and moves them to the bottom of their pile. It is then their turn again to choose a category from the next card. If two or more cards share the top value or data is not available for that particular subject then all the cards are placed in the middle and the same player chooses again from the next card. The winner of the hand takes the cards in the middle as well. The person with all the cards at the end is the winner.";
            }
        }
        public List<Bass> stokkur = new List<Bass>();
        public static Player[] CharacterStokkurinn = {  new Player("LightNir", "Rogue/arcane trickster", "Half elf", 14, 13, 12, 17, 10, 16, 12, 10),
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

        public static Bass[] MonsterStokkurinn = {
                                        new Bass("Chimera",new double[]{14,114,19,11,19,3,14,10},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Cyclops", new double[]{14,138,22,11,20,8,6,10},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Chasme", new double[]{15,84,15,15,12,11,14,10},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Vrock", new double[]{15,104,17,15,18,8,13,8},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Young White Dragon", new double[]{17,133,18,10,18,6,11,12},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Young Brass Dragon", new double[]{17,110,19,10,17,12,11,15},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Drider", new double[]{19,123,16,16,18,13,14,12},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Galeb Duhr", new double[]{16,85,20,14,20,11,12,11},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Githzerai Zerth", new double[]{17,84,13,18,15,16,17,12},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Hobgoblin Warlord", new double[]{20,97,16,14,16,14,11,15},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Invisible Stalker", new double[]{14,104,16,19,14,10,15,11},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Kuo-Toa Archpriest", new double[]{13,97,16,14,16,13,16,14},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Medusa", new double[]{15,127,10,15,16,12,13,15},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Wyvern", new double[]{13,110,19,10,16,5,12,6},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Mammoth", new double[]{13,126,24,9,21,3,11,6},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Mage", new double[]{12,40,9,14,11,17,12,11},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Young Black Dragon", new double[]{18,127,19,14,17,12,11,15},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Young Copper Dragon", new double[]{17,119,19,12,17,16,13,15},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Drow Mage", new double[]{12,45,9,14,10,17,13,12},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Stone Giant", new double[]{17,126,23,15,20,10,12,9},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Grick Alpha", new double[]{18,75,18,16,15,4,14,9},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Mind Flayer", new double[]{15,71,11,12,12,19,17,17},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Oni", new double[]{16,110,19,11,16,14,12,15},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Shield Guardian", new double[]{17,142,18,8,18,7,10,3},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Blue Slaad", new double[]{15,123,20,15,18,7,7,9},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Yuan-Ti Abomination", new double[]{15,127,19,16,17,17,15,18},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Giant Ape", new double[]{12,157,23,14,18,7,12,7},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Young Green Dragon", new double[]{18,136,19,12,17,16,13,15},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Cloaker", new double[]{14,78,17,15,12,13,12,14},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Hezrou", new double[]{16,136,19,17,20,5,12,13},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Chain Devil", new double[]{16,85,18,15,18,11,12,14},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Tyrannosaurus Rex", new double[]{13,136,25,10,19,2,12,9},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Young Bronze Dragon", new double[]{18,142,21,10,19,14,13,17},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Drow Priestess of Lolth", new double[]{16,71,10,14,12,13,17,18},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Fomorian", new double[]{14,149,23,10,20,9,14,6},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Frost Giant", new double[]{15,138,23,9,21,9,10,12},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Githyanki Knight", new double[]{18,91,16,14,15,14,14,15},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Hydra", new double[]{15,172,20,12,20,2,10,7},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Spirit Naga", new double[]{15,75,18,17,14,16,15,15},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Green Slaad", new double[]{16,127,18,15,16,11,8,12},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Assassin", new double[]{15,78,11,16,14,13,11,10},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Glabrezu", new double[]{17,157,20,15,21,19,17,16},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Bone Devil", new double[]{19,142,18,16,18,13,14,16},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Young Blue Dragon", new double[]{18,152,21,10,19,14,13,17},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Young Silver Dragon", new double[]{18,168,23,10,21,14,11,19},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Cloud Giant", new double[]{14,200,27,10,22,12,16,16},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Fire Giant", new double[]{18,162,25,9,23,10,14,13},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Clay Golem", new double[]{14,133,20,9,18,3,8,1},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Gray Slaad", new double[]{18,127,17,17,16,13,8,14},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Treant", new double[]{16,138,23,8,21,12,16,12},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Abominable Yeti", new double[]{15,137,24,10,22,9,13,9},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"}),
                                        new Bass("Nycaloth", new double[]{18,123,20,11,19,12,10,15},new string[]{"Armor Class", "Hit Points","Strength","Dexterity", "Constitution", "intelligence", "Wisdom", "Charisma"})
                                     };

        public Bass[][] stokkarnir = { CharacterStokkurinn, MonsterStokkurinn };
        public string[] StokkaNofn = { "Character Stokkur(D&D)", "Monster Stokkur(D&D)" };

        public double[] AvgStats(int stokkurNb)
        {
            double[] AvgStat = new double[stokkarnir[stokkurNb][0].Stats.Length];
            double[][] kek = new double[stokkarnir[stokkurNb][0].Stats.Length][];//ytri eru stöt, innri eru gildi
            for (int i = 0; i < stokkarnir[stokkurNb][0].Stats.Length; i++)//hvaða statti erum við á?
            {
                kek[i] = new double[stokkarnir[stokkurNb].Length];
                for (int k   = 0; k < stokkarnir[stokkurNb].Length; k++)//hvaða spili?
			    {
                    kek[i][k]=stokkarnir[stokkurNb][k].Stats[i];
			    }
                AvgStat[i] = kek[i].Average();
            }
            return AvgStat;
        }
        public List<Bass> getDeck(int val)
        {
            List<Bass> stokkur = new List<Bass>();
            for (int i = 0; i < stokkarnir[val].Length; i++)
            {
                stokkur.Add(stokkarnir[val][i]);
            }
            return stokkur;
        }
        
    }
}
