using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst;

public class Shipper
{
    public int ShipperId { get; set; }

    [Required, MaxLength(40)]
    public string CompanyName { get; set; }

    [MaxLength(24)]
    public int Phone { get; set; }
}
