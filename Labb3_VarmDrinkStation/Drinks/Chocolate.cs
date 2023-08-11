
namespace Labb3_VarmDrinkStation.Drinks
{
    internal class Chocolate : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Your chocolate is served.");
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
