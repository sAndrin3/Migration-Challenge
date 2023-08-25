namespace Assessment4.Models{
public class Product {
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }

    public List<Order> Carts { get; set; }
}
}