namespace Assessment4.Models{
public class Shipment {
    public int ShipmentId { get; set; }
    public DateTime ShipmentDate { get; set; }

    // Foreign Keys
    public int OrderId { get; set; }

    public Order Order { get; set; }
}
}