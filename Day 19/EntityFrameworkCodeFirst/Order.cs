using EFCodeFirst;

namespace EntityFrameworkCodeFirst;

public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public int EmployeeId { get; set; }
    public int ShipperId { get; set; }
    public string ShipCountry { get; set; }
    public Shipper Shipper { get; set; }

}
