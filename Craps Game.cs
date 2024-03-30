using System;

public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();

        int DiceRoll()
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int total = die1 + die2;
            Console.WriteLine($"Player rolled {die1} + {die2} = {total}");
            return total;
        }

    
        int sum = DiceRoll();

        string game_status;
        int point = 0;

        if (sum == 7 || sum == 11)
        {
            game_status = "WON";
        }
        else if (sum == 2 || sum == 3 || sum == 12)
        {
            game_status = "LOST";
        }
        else
        {
            game_status = "Continue";
            point = sum;
            Console.WriteLine("Point is " + point);
        }

    
        while (game_status == "Continue")
        {
            sum = DiceRoll();

            if (sum == point) 
            {
                game_status = "WON";
            }
            else if (sum == 7) 
            {
                game_status = "LOST";
            }
        }

        if (game_status == "WON")
        {
            Console.WriteLine("Player wins!");
        }
        else
        {
            Console.WriteLine("Player loses...");
        }
    }
}
