global using Labb3_VarmDrinkStation.Drinks;
global using Labb3_VarmDrinkStation.Interface;

namespace Labb3_VarmDrinkStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var machine = new WarmDrinkMachine();
            IWarmDrink drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}