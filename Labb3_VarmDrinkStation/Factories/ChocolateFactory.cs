
namespace Labb3_VarmDrinkStation.Factories
{
    internal class ChocolateFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"> Pour {total} ml hot water in your cup");
            Console.WriteLine($">> Adding chocolate powder to your cup");
            return new Chocolate();
        }
    }
}
