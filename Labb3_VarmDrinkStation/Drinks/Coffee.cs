
namespace Labb3_VarmDrinkStation.Drinks
{
    internal class Coffee : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Your coffee is served.");
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
