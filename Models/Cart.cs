using System.ComponentModel.DataAnnotations;

namespace Assessment4.Models{
public class Cart {
    [Key]
    public int CardId { get; set; }
    public int Quantity{ get; set; }

    // Foreign Keys
    public int UserId { get; set; }

    public User User { get; set; }

    public int ProductId {get; set; }
    public Product Product {get; set;}
}
}