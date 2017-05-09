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

            //breytur
            Random random = new Random();
            int stokkavalmynd = 0;
            int botvalmynd = 0;
            stokkurDnD Stokkar = new stokkurDnD();

            //stokk valmynd
            Console.WriteLine("Veldu stokk:");
            for (int i = 0; i < Stokkar.stokkarnir.Length; i++)
            {
                Console.WriteLine("\t" + (1+i) + ". " + Stokkar.StokkaNofn[i] + ".");
            }
            Console.WriteLine("0. Hætta.");
            try
            {
                stokkavalmynd = Convert.ToInt32(Console.ReadLine())-1;
            }catch (Exception){}

            //while player vill spila
            while ((stokkavalmynd + 1) != 0)
            {

                Console.Clear();
                //fleirri breytur
                bool PlayersTurn = true;
                int input=0;

                List<Bass> stokkur = shofle(Stokkar.getDeck(stokkavalmynd));//shofflar stokkinn
                double[] avgStats = Stokkar.AvgStats(stokkavalmynd);
                List<Bass> Aistokkur = new List<Bass>();
                List<Bass> Playerstokkur = new List<Bass>();
                List<Bass> cardPool = new List<Bass>();

                //skiftir stokkinum í tvent
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

                //AI
                ArtificialBot[] Bots = {new HardAI(avgStats), new MediumAI(avgStats), new EasyAI(avgStats)};

                //AI valmynd
                Console.WriteLine("Veldu erfiðleikastig:");
                for (int i = 0; i < Bots.Length; i++)
                {
                    Console.WriteLine("\t" + (i) + ". " + Bots[i].ToString() + ".");
                }
                try
                {
                    botvalmynd = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception) {}

                //while no one has lost
                while (Playerstokkur.Count > 0 && Aistokkur.Count > 0)
                {
                    if (PlayersTurn)//who picks?
                    {
                        //input = Bots[botvalmynd].AI(Aistokkur[0]);
                        
                        do
                        {
                            //skrifar út current spilið fyrir valmynd
                            Console.Clear();
                            Console.WriteLine("Player deck size: " + Playerstokkur.Count + " vs AI deck size: " + Aistokkur.Count);
                            Console.WriteLine(Playerstokkur[0]+"\n");
                            for (int i = 0; i < stokkur[0].StatsName.Length; i++)
                            {
                                Console.WriteLine(i + ")" + stokkur[0].StatsName[i]);
                            }
                            Console.Write("Select the stat(the number): ");
                            input = Convert.ToInt16(Console.ReadLine());
                        } while (input < 0 || input > stokkur[0].StatsName.Length);
                        PlayersTurn = false;//skiftir um hver á að gera
                    }
                    else
                    {
                        input = Bots[botvalmynd].AI(Aistokkur[0]);//fer í AI classann
                        PlayersTurn = true;//setur aftur á player's turn
                    }
                    Console.Clear();

                    //skrifar út útkomuna af spilonum
                    if (PlayersTurn)
                    {
                        Console.WriteLine("Player deck size: " + Playerstokkur.Count + " vs AI deck size: " + Aistokkur.Count);
                        Console.WriteLine("AI picks: "+stokkur[0].StatsName[input]);
                                
                    }
                    Console.WriteLine("Player: "+ Playerstokkur[0].Stats[input]+" vs AI: "+Aistokkur[0].Stats[input]);
                    Console.WriteLine(Playerstokkur[0]);
                    Console.WriteLine("vs");
                    Console.WriteLine(Aistokkur[0]);
                    Console.ReadKey();

                    //ef jafntefli þá setur 
                    if (Playerstokkur[0].Stats[input] == Aistokkur[0].Stats[input])
                    {
                        cardPool.Add(Playerstokkur[0]);
                        cardPool.Add(Aistokkur[0]);
                        Playerstokkur.Remove(Playerstokkur[0]);
                        Aistokkur.Remove(Aistokkur[0]);
                    }

                    //ef playerinn vinnur
                    else if (Playerstokkur[0].Stats[input] > Aistokkur[0].Stats[input])
                    {
                            //random röð aftast í stokkinn
                            if (random.Next(0,1)<0.5)
                            {
                                Playerstokkur.Add(Playerstokkur[0]);
                                Playerstokkur.Add(Aistokkur[0]);
                            }
                            else
                            {
                                Playerstokkur.Add(Aistokkur[0]);
                                Playerstokkur.Add(Playerstokkur[0]);
                            }
                            Aistokkur.Remove(Aistokkur[0]);
                            Playerstokkur.Remove(Playerstokkur[0]);
                            cardPool = shofle(cardPool);//shufflar cardPool
                            for (int i = 0; i < cardPool.Count();)
                            {
                                Playerstokkur.Add(cardPool[0]);
                                cardPool.Remove(cardPool[0]);
                            }
                    }
                    else
                    {
                            //random röð aftast í stokkinn
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
                            cardPool = shofle(cardPool);//shufflar cardPool
                            for (int i = 0; i < cardPool.Count();)
                            {
                                Aistokkur.Add(cardPool[0]);
                                cardPool.Remove(cardPool[0]);
                            }
                    }
                }
                Console.ReadKey();

            };
        }

        //shufflar spil
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
