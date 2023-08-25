namespace Assessment4.Models{
public class Order {
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }

    // Foreign Keys
    public int UserId { get; set; }

    public User User { get; set; }
}
}