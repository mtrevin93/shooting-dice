using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public int Roll (int otherRoll)
        {
            return otherRoll + 1;
        }
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int otherRoll = other.Roll();
            if (other is HumanPlayer)
            {
                otherRoll = int.Parse(Console.ReadLine());
            }
            int myRoll = otherRoll + 1;

            Flavor();
            Console.WriteLine($"{Name} rolls a {myRoll}");
            other.Flavor();
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                if (other is ISoreLoser)
                {
                    other.PlayerFlipsTable();
                }
                else 
                {
                    Console.WriteLine($"{Name} Wins!");
                }
            }
            else if (myRoll < otherRoll)
            {
                if (this is ISoreLoser)
                {
                    PlayerFlipsTable();
                }
                else
                {
                    Console.WriteLine($"{other.Name} Wins!");
                }
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}
