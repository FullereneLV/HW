using static System.Console;

namespace StoreInventorySystem;

public class Fish : AbstractProducts, ICounteable
{
    
    public Fish(string name, double price, int quantity) : base(name, price, quantity)
    {
    }
   public void CountAmount()
    {
        WriteLine(Quantity);
    }
}
