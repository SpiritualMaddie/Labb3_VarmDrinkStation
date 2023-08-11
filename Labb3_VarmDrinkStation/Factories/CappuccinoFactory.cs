
namespace Labb3_VarmDrinkStation.Factories
{
    internal class CappuccinoFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"> Pour {total} ml hot water in your cup");
            Console.WriteLine($">> Adding dark roast coffee to your cup");
            Console.WriteLine($">>> Adding foamed milk");
            return new Cappuccino();
        }
    }
}
