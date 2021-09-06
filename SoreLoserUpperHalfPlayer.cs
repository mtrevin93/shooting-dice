namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : SoreLoserPlayer
    {
        public override int Roll()
        {
            // Rolls in upper half
            return new Random().Next(DiceSize/2 +1, DiceSize +1);
        }
    }
}