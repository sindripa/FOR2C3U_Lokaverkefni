using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTrumpsDnD;

namespace DnD
{
    class Program
    {
        static void Main(string[] args)
        {

            //stokka val
            int stokkavalmynd = 0;
            stokkurDnD kek0 = new stokkurDnD(0);
            Console.WriteLine("Veldu stokk:");
            for (int i = 1; i <= kek0.stokkarnir.Length; i++)
            {
                Console.WriteLine("\t" + i + ". Stokkur " + i + ".");
            }
            Console.WriteLine("0. Hætta.");
            try
            {
                stokkavalmynd = Convert.ToInt32(Console.ReadLine());
            }catch (Exception ex){}

            do
            {
                Console.Clear();
                bool PlayersTurn = true;
                double input=8;
                
                if (stokkavalmynd <= (kek0.stokkarnir.Length - 1))
                {
                    stokkurDnD kek = new stokkurDnD(stokkavalmynd);
                }
                List<Bass> stokkur = shofle(kek.stokkur);
                List<Bass> Aistokkur = new List<Bass>();
                List<Bass> Playerstokkur = new List<Bass>();
                List<Bass> cardPool = new List<Bass>();
                for (int i = 0; i < 52; i++)
                {
                    if (26>i)
                    {
                        Playerstokkur.Add(stokkur[i]);
                    }
                    else
                    {
                        Aistokkur.Add(stokkur[i]);
                    }
                }
                while (Playerstokkur.Count > 0 && Aistokkur.Count > 0)
                {
                    if (PlayersTurn)//who picks?
                    {
                        input = AI(Playerstokkur[0], kek);
                        /*
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Player: " + Playerstokkur.Count + " vs AI: " + Aistokkur.Count);
                            Console.WriteLine(Playerstokkur[0]);
                            Console.WriteLine("\n0)Armor class");
                            Console.WriteLine("1)Health Points");
                            Console.WriteLine("2)Strength");
                            Console.WriteLine("3)Dexterity");
                            Console.WriteLine("4)Constitution");
                            Console.WriteLine("5)Intelligence");
                            Console.WriteLine("6)Wistom");
                            Console.WriteLine("7)Charisma");
                            Console.Write("Select the stat(the number): ");
                            input = Convert.ToInt16(Console.ReadLine());
                        } while (input < 0 || input > 7);*/
                        PlayersTurn = false;
                    }
                    else
                    {
                        input = AI(Aistokkur[0], kek);
                        PlayersTurn = true;
                    }
                    Console.Clear();
                    if (PlayersTurn)
                    {
                        switch (input)
                        {
                            case 0:
                                Console.WriteLine("AI picks Armor class");
                                break;
                            case 1:
                                Console.WriteLine("AI picks Health");
                                break;
                            case 2:
                                Console.WriteLine("AI picks Strength");
                                break;
                            case 3:
                                Console.WriteLine("AI picks Dexterity");
                                break;
                            case 4:
                                Console.WriteLine("AI picks Constitution");
                                break;
                            case 5:
                                Console.WriteLine("AI picks Intelligence");
                                break;
                            case 6:
                                Console.WriteLine("AI picks Wistom");
                                break;
                            case 7:
                                Console.WriteLine("AI picks Charisma");
                                break;
                            default:
                                Console.WriteLine("ehhh");
                                break;
                        }
                    }
                    Console.WriteLine("Player: "+ Playerstokkur[0].Stats[input]+" vs AI: "+Aistokkur[0].Stats[input]);
                    Console.WriteLine(Playerstokkur[0]);
                    Console.WriteLine("vs");
                    Console.WriteLine(Aistokkur[0]);
                    Console.ReadKey();
                    if (Playerstokkur[0].Stats[input] == Aistokkur[0].Stats[input])
                    {
                        cardPool.Add(Playerstokkur[0]);
                        cardPool.Add(Aistokkur[0]);
                        Playerstokkur.Remove(Playerstokkur[0]);
                        Aistokkur.Remove(Aistokkur[0]);
                    }
                    else if (Playerstokkur[0].Stats[input] > Aistokkur[0].Stats[input])
                    {
                        Playerstokkur.Add(Playerstokkur[0]);
                        Playerstokkur.Add(Aistokkur[0]);
                        Playerstokkur.Remove(Playerstokkur[0]);
                        Aistokkur.Remove(Aistokkur[0]);
                        cardPool = shofle(cardPool);
                        for (int i = 0; i < cardPool.Count();)
                        {
                            Playerstokkur.Add(cardPool[0]);
                            cardPool.Remove(cardPool[0]);
                        }
                    }
                    else
                    {
                        Aistokkur.Add(Aistokkur[0]);
                        Aistokkur.Add(Playerstokkur[0]);
                        Playerstokkur.Remove(Playerstokkur[0]);
                        Aistokkur.Remove(Aistokkur[0]);
                        cardPool = shofle(cardPool);
                        for (int i = 0; i < cardPool.Count();)
                        {
                            Aistokkur.Add(cardPool[0]);
                            cardPool.Remove(cardPool[0]);
                        }
                    }
                }
                Console.ReadKey();

            } while (stokkavalmynd != "0");
        }

        public static double AI(Bass dude, stokkurDnD kek)
        {
            double[] shift = new double[8];
            for (int i = 0; i < 8; i++)
            {
                shift[i] = dude.Stats[i]-kek.StatsAvg[i];
            }
            for (double i = 0; i < 8; i++)
            {
                if (shift[i]==shift.Max())
                {
                    return i;
                }
            }
            return 1;
        }

        public static List<Bass> shofle(List<Bass> kok)
        {
            List<Bass> oldone = kok;
            List<Bass> newone = new List<Bass>();
            int init;
            Random rand = new Random();
            for (int i = 0; i < oldone.Count;)//rennur þangað til að stokkur klárast
            {
                init = rand.Next(0, oldone.Count);
                newone.Add(oldone[init]);
                oldone.Remove(oldone[init]);
            }
            return newone;
        }
    }
}
