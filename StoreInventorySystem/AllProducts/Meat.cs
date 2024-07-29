namespace StoreInventorySystem;

public class Meat : AbstractProducts, ICounteable
{

    public Meat(string name, double price, int quantity) : base(name, price, quantity)
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
