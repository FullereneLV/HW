namespace StoreInventorySystem;

public class Vegetables : AbstractProducts, ICounteable
{

    public Vegetables(string name, double price, int quantity) : base(name, price, quantity)
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
