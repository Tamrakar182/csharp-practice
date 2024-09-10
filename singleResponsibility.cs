// A class should have only one job/responsibility
public class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
}

public class Invoice
{
    // here every method has only one thing to do, 
    // like get the total, print the invoice, add item

    private List<Item> items;
    public Invoice()
    {
        items = new List<Item>();
    }
    public double GetTotal()
    {
        double total = 0;
        foreach (var item in items)
        {
            total += item.Price;
        }
        return total;

    }

    public void PrintInvoice()
    {
        Console.WriteLine("Invoice:");
        foreach (var item in items)
        {
            Console.WriteLine($"Item: {item.Name}, Price: {item.Price}");
        }
        Console.WriteLine($"Total: {GetTotal()}");

    }
    public void AddItem(Item item)
    {
        items.Add(item);
    }

}
