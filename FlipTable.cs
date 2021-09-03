using System;
namespace ShootingDice
{
    public class FlipTable : Exception
    {

        public static string FlipTableMessage = "Uh oh, the table got flipped.";

        public FlipTable( ) :
        
            base( FlipTableMessage )
        { }
    }

}