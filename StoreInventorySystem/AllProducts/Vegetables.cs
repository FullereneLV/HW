namespace StoreInventorySystem.AllProducts;

public class Vegetables : AbstractProducts, ICounteable
{

    public Vegetables(string name, double price, int quantity) : base(name, price, quantity)
    {
    }

    public int CountAmount()
    {
        return Quantity;
    }
}
