public class Program
{

    public static void Main(string[] args)
    {
        GameStart();
        Game();


    }
    public static int NumGen()
    {
        Random rnd = new Random();
        int Dice = (rnd.Next(1,7));
        return Dice;
    }

    public static void GameStart()
    {
        Console.WriteLine("Dice Game");
        Console.WriteLine();
        Console.WriteLine("in this game you and a computor rival will play 10 rounds where you will both roll a 6-sidded die");
        Console.WriteLine("and the player with the highest dice value will win the round. the player who wins the most rounds wins wins the game. good luck!");
        Console.WriteLine("press any key to start");
        Console.ReadKey();
        Console.WriteLine();
    }
    public static void Game()
    {
        int PlayerP = 0;
        int RivalP = 0;


        for (int l = 1; l < 11; l++)
        {
            
            int Rival = NumGen();
            int Player = NumGen();

            Console.WriteLine($"round {l}");
            Console.WriteLine($"Rival rolled a {Rival}");
            Console.WriteLine("press any key to roll dice...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"you rolled a {Player}");
            if (Rival < Player)
            {
                Console.WriteLine("you lost");
                RivalP += 1;
            }
            else if (Rival == Player)
            {
                Console.WriteLine("draw");
            }
            else
            {
                Console.WriteLine("you won");
                PlayerP += 1;
            }

            Console.WriteLine($"the score is now - player:{PlayerP} Rival{RivalP}");
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }
        Console.WriteLine("Game Over.");
        Console.WriteLine($"the score is now - player:{PlayerP} rival:{RivalP}");
        if(PlayerP>RivalP)
        {
            Console.WriteLine("You Won!");
        }
        else if(RivalP>PlayerP)
        {
            Console.WriteLine("You Lost!");
        }
        else
        {
            Console.WriteLine("Draw!");
        }
        Console.WriteLine("press any key to exit...");
            Console.ReadKey();
            Console.WriteLine();
    }
}
