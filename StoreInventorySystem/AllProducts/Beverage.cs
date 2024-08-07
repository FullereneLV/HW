namespace StoreInventorySystem.AllProducts;

public class Beverage : AbstractProducts, ICounteable
{
    public Beverage(): base()
    {
    }

    public Beverage(string name, double price, int quantity) : base(name, price, quantity)
    {
    }

    public int CountAmount()
    {
        return Quantity;
    }

}
