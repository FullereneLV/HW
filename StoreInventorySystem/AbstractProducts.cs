namespace StoreInventorySystem;

public abstract class AbstractProducts
{
    public string Name;
    public double Price;
    public int Quantity;

    public AbstractProducts(){
        
    }

    public AbstractProducts(string name, double price, int quantity){
        Name = name;
        Price = price;
        Quantity = quantity;
    }

}
