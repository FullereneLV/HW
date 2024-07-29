using static System.Console;

namespace StoreInventorySystem;

public class Beverage : AbstractProducts, ICounteable
{
    public Beverage(): base()
    {
    }

    public Beverage(string name, double price, int quantity) : base(name, price, quantity)
    {
    }

    public void CountAmount()
    {
        WriteLine(Quantity);
    }

}
