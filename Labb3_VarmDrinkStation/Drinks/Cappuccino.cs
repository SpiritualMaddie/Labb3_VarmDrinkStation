
namespace Labb3_VarmDrinkStation.Drinks
{
    internal class Cappuccino : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Your cappuccino is served.");
            Console.WriteLine(@"
         )  (
        (   ) )
         ) ( (
       _______)_
    .-'---------|  
   ( C|/\/\/\/\/|
    '-./\/\/\/\/|
      '_________'
       '-------'
~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
