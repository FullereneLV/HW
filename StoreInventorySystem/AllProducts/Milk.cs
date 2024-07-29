namespace StoreInventorySystem;

public class Milk : AbstractProducts, ICounteable
{

    public Milk(string name, double price, int quantity) : base(name, price, quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public void CountAmount()
    {
        throw new NotImplementedException();
    }
}
