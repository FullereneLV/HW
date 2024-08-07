namespace StoreInventorySystem.AllProducts;

public class Milk : AbstractProducts, ICounteable
{

    public Milk(string name, double price, int quantity) : base(name, price, quantity)
    {
    }

    public int CountAmount()
    {
        return Quantity;
    }
}
