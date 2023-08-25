using Assessment4.Data;

namespace Assessment4.Models{
public class Payment {
    public int PaymentId { get; set; }
    public decimal Amount{ get; set; }

    // Foreign Keys
    public int OrderId { get; set; }

    public Order Order { get; set; }
}
}