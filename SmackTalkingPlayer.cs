using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public override void Flavor()
        {
            Console.WriteLine($"{Name}: \"I'm gonna win, punk!\"");
        }
    }
}