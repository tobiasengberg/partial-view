namespace Catalogue.Models.ViewModels;

public class CompanyViewModel
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string RegNumber { get; set; }

    public CompanyViewModel()
    {
        
    }
    public CompanyViewModel(int id, string brand, string regNumber)
    {
        Id = id;
        Brand = brand;
        RegNumber = regNumber;
    }
}