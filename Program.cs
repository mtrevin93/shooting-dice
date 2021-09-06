using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new SoreLoserPlayer();
            player1.Name = "Billy";

            Player player2 = new OneHigherPlayer();
            player2.Name = "Sue";

            player2.Play(player1);

            Player player3 = new HumanPlayer();
            player3.Name = "Wilma";

            Player player4 = new CreativeSmackTalkingPlayer();
            player4.Name = "Rob";

            Player player5 = new SmackTalkingPlayer();
            player5.Name = "Bob";

            Player player6 = new UpperHalfPlayer();
            player6.Name = "Freddy";

            player5.Play(player6);
            player6.Play(player5);

            player3.Play(player4);

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            List<Player> players = new List<Player>() {
                player1, player2, player3, player4, player5, player6, large
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}