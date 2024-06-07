using TwoTaxiApp.Domain.Common;

namespace TwoTaxiApp.Domain;

public class TaxiDriver : Person
{
    public string Plate { get; set; }
    public string DriverLicenceNumber { get; set; }
}