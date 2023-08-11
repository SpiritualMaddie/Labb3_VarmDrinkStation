
namespace Labb3_VarmDrinkStation.Factories
{
    internal class CoffeeFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"> Pour {total} ml hot water in your cup");
            Console.WriteLine($">> Adding coffee powder to your cup");
            return new Coffee();
        }
    }
}
