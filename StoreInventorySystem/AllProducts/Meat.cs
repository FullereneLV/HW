namespace StoreInventorySystem.AllProducts;

public class Meat : AbstractProducts, ICounteable
{

    public Meat(string name, double price, int quantity) : base(name, price, quantity)
    {
    }

    public int CountAmount()
    {
        return Quantity;
    }
}
