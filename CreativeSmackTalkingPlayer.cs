using System.Collections.Generic;
using System;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public static List<string> Insults = new List<string> 
        {
            "You don't stand a chance!",
            "You smell bad!",
            "You roll dice like my grandmother!",
            "Everyone knows you're gonna lose!"
        };
        public override void Flavor()
        {
            Console.WriteLine($"{Name}: {Insults[new Random().Next(0, 4)]}");
        }
    }
}