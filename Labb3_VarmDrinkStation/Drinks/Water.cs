
namespace Labb3_VarmDrinkStation.Drinks
{
    internal class Water : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Your warm water is served.");
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
