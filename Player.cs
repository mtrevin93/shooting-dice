using System;

namespace ShootingDice
{
    public class Player
    {
        public string Name { get; set; }
        public int DiceSize { get; set; } = 6;

        public virtual int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }

        public virtual string Flavor()
        {
            return "";
        }

        public virtual void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();
            if (other is OneHigherPlayer)
            {
                otherRoll = (other as OneHigherPlayer).Roll(myRoll);
            }
            Console.WriteLine($"{Name} rolls a {myRoll}");
            Flavor();
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            other.Flavor();
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}