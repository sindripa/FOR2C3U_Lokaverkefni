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
            Random random = new Random();
            int stokkavalmynd = 0;
            stokkurDnD Stokkar = new stokkurDnD();
            Console.WriteLine("Veldu stokk:");
            for (int i = 0; i < Stokkar.stokkarnir.Length; i++)
            {
                Console.WriteLine("\t" + i + ". Stokkur " + Stokkar.stokkarnir[i] + ".");
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
                int input=0;

                List<Bass> stokkur = shofle(Stokkar.getDeck(stokkavalmynd));
                double[] avgStats = Stokkar.AvgStats(stokkavalmynd);
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
                        //input = AI(Playerstokkur[0], avgStats);
                        
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Player: " + Playerstokkur.Count + " vs AI: " + Aistokkur.Count);
                            Console.WriteLine(Playerstokkur[0]+"\n");
                            for (int i = 0; i < stokkur[0].StatsName.Length; i++)
                            {
                                Console.WriteLine(i + ")" + stokkur[0].StatsName[i]);
                            }
                            Console.Write("Select the stat(the number): ");
                            input = Convert.ToInt16(Console.ReadLine());
                        } while (input < 0 || input > stokkur[0].StatsName.Length);
                        PlayersTurn = false;
                    }
                    else
                    {
                        input = AI(Aistokkur[0], avgStats);
                        PlayersTurn = true;
                    }
                    Console.Clear();
                    if (PlayersTurn)
                    {
                        Console.WriteLine("AI "+stokkur[0].StatsName[input]);
                                
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
                        if (random.Next(0,1)<0.5)
                        {
                            Playerstokkur.Add(Playerstokkur[0]);
                            Playerstokkur.Add(Aistokkur[0]);
                        }
                        else
                        {
                            Aistokkur.Remove(Aistokkur[0]);
                            Playerstokkur.Remove(Playerstokkur[0]);
                        }
                        cardPool = shofle(cardPool);
                        for (int i = 0; i < cardPool.Count();)
                        {
                            Playerstokkur.Add(cardPool[0]);
                            cardPool.Remove(cardPool[0]);
                        }
                    }
                    else
                    {
                        if (random.Next(0, 1) < 0.5)
                        {
                            Aistokkur.Add(Aistokkur[0]);
                            Aistokkur.Add(Playerstokkur[0]);
                        }
                        else
                        {
                            Aistokkur.Add(Playerstokkur[0]);
                            Aistokkur.Add(Aistokkur[0]);
                        }
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

            } while (stokkavalmynd != 0);
        }

        public static int AI(Bass dude, double[] avgStats)
        {
            double[] shift = new double[8];
            for (int i = 0; i < 8; i++)
            {
                shift[i] = dude.Stats[i] / avgStats[i];
            }
            for (int i = 0; i < 8; i++)
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
