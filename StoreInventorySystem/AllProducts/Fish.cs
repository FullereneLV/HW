namespace StoreInventorySystem.AllProducts;

public class Fish : AbstractProducts, ICounteable
{

    public Fish(string name, double price, int quantity) : base(name, price, quantity)
    {
    }
    public int CountAmount()
    {
        return Quantity;
    }
}
