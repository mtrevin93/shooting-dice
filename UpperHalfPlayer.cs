using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // Rolls in upper half
            return new Random().Next(DiceSize/2 +1, DiceSize +1);
        }
    }
}