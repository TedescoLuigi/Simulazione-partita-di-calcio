namespace Simulazione_partita_di_calcio
{
    internal class Program
    {
        static int RandomGoal()//da toglier ee mettere sul main
        {
            Random random = new Random();
            return random.Next(0, 11);
        }

        static int RandomVincitaA()()//da toglier ee mettere sul main
        {
            Random random = new Random();
            return random.Next(0, 61);
        }

        //genera squadra A potenziale
        static int[] RandomPotenziale()
        { 
            
            int[] giocatori = new int[11];
            Random rand = new Random();

            for (int j = 0; j < 11; j++)
            {
                giocatori[j] = rand.Next(0, 100);
            }

            return giocatori;
        }


        //potenziale somma  squadre A
        static int SommaTotaleA(int[] squadraA)
        {
            int totaleA = 0;
            for(int i=0;i<squadraA.Length;i++)
            {
                totaleA += squadraA[i];

            }
            return totaleA;
        }

        //potenziale somma  squadre B
        static int SommaTotaleB(int[] squadraB)
        {
            int totaleB = 0;
            for (int i = 0; i < squadraB.Length; i++)
            {
                totaleB += squadraB[i];

            }
            return totaleB;
        }
        static void Main(string[] args)
        {
            //sqaudra A e B
            int[] SquadraA = RandomPotenziale();
            int[] SquadraB = RandomPotenziale();

            Console.Write("lA SQUADRA A ");
            for (int j=0;j<SquadraA.Length;j++)
            {
                Console.Write("[" + SquadraA[j] + "]");
            }
            Console.WriteLine();
            Console.Write("lA SQUADRA B ");
            for (int k=0;k<SquadraB.Length;k++)
            {
                Console.Write("[" + SquadraB[k] + "]");
            }
            Console.WriteLine();

            //TOTALE SQUADRE
            int totaleA = SommaTotaleA(squadraA);
            int totaleB = SommaTotaleB(squadraB);

            int tot = 0;
            int tot= totaleA + totaleB;


            //ciclo simulazione partita 90 minuti
            for (int i = 0; i < 90; i++)
            {

                if (RandomGoal() > 20)
                {
                    Console.WriteLine($"Minuto {i + 1}: Nessun goal");

                }
                else if (RandomGoal() <= 20)
                {
                    Console.WriteLine($"Minuto {i + 1}: Goal");


                }
            }
        }
    }
}
