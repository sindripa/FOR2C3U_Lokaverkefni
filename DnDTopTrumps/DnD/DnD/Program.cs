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
            bool PlayersTurn = true;
            short input=8;
            stockurDnD kek = new stockurDnD();
            List<Player> stockur = shofle(kek.stockur);
            List<Player> AiStockur = new List<Player>();
            List<Player> PlayerStockur = new List<Player>();
            List<Player> cardPool = new List<Player>();
            for (int i = 0; i < 52; i++)
            {
                if (26>i)
                {
                    PlayerStockur.Add(stockur[i]);
                }
                else
                {
                    AiStockur.Add(stockur[i]);
                }
            }
            while (PlayerStockur.Count > 0 && AiStockur.Count > 0)
            {
                if (PlayersTurn)//who picks?
                {
                    input = AI(PlayerStockur[0], kek);
                    /*
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Player: " + PlayerStockur.Count + " vs AI: " + AiStockur.Count);
                        Console.WriteLine(PlayerStockur[0]);
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
                    input = AI(AiStockur[0], kek);
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
                Console.WriteLine("Player: "+ PlayerStockur[0].Stats[input]+" vs AI: "+AiStockur[0].Stats[input]);
                Console.WriteLine(PlayerStockur[0]);
                Console.WriteLine("vs");
                Console.WriteLine(AiStockur[0]);
                Console.ReadKey();
                if (PlayerStockur[0].Stats[input] == AiStockur[0].Stats[input])
                {
                    cardPool.Add(PlayerStockur[0]);
                    cardPool.Add(AiStockur[0]);
                    PlayerStockur.Remove(PlayerStockur[0]);
                    AiStockur.Remove(AiStockur[0]);
                }
                else if (PlayerStockur[0].Stats[input] > AiStockur[0].Stats[input])
                {
                    PlayerStockur.Add(PlayerStockur[0]);
                    PlayerStockur.Add(AiStockur[0]);
                    PlayerStockur.Remove(PlayerStockur[0]);
                    AiStockur.Remove(AiStockur[0]);
                    cardPool = shofle(cardPool);
                    for (int i = 0; i < cardPool.Count();)
                    {
                        PlayerStockur.Add(cardPool[0]);
                        cardPool.Remove(cardPool[0]);
                    }
                }
                else
                {
                    AiStockur.Add(AiStockur[0]);
                    AiStockur.Add(PlayerStockur[0]);
                    PlayerStockur.Remove(PlayerStockur[0]);
                    AiStockur.Remove(AiStockur[0]);
                    cardPool = shofle(cardPool);
                    for (int i = 0; i < cardPool.Count();)
                    {
                        AiStockur.Add(cardPool[0]);
                        cardPool.Remove(cardPool[0]);
                    }
                }
            }
            Console.ReadKey();
        }

        public static short AI(Player dude, stockurDnD kek)
        {
            double[] shift = new double[8];
            for (int i = 0; i < 8; i++)
            {
                shift[i] = dude.Stats[i]-kek.StatsAvg[i];
            }
            for (short i = 0; i < 8; i++)
            {
                if (shift[i]==shift.Max())
                {
                    return i;
                }
            }
            return 1;
        }

        public static List<Player> shofle(List<Player> kok)
        {
            List<Player> oldone = kok;
            List<Player> newone = new List<Player>();
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
