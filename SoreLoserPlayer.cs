using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Flavor()
        {
            try
            {
                throw new FlipTable();
            }
            catch(FlipTable ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("But we set things back up! The game must go on.");
            }
        }
    }
}