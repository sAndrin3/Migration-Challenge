namespace Assessment4.Models{
    public class User {
    public int UserId {get; set; }
    public string Username {get; set; }

    public string email {get; set; }

    public int ContactNumber {get; set;}

    public List<Order> Orders {get; set; }
}
}
