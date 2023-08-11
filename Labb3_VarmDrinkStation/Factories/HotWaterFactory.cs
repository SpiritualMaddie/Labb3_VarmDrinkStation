
namespace Labb3_VarmDrinkStation.Factories
{
    internal class HotWaterFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"> Pour {total} ml hot water in your cup");
            return new Water();
        }
    }
}
