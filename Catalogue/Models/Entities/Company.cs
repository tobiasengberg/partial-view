namespace Catalogue.Models.Entities;

public class Company
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string RegNumber { get; set; }
    public string BankAccount { get; set; }

    public Company(int id, string brand, string regNumber, string bankAccount)
    {
        Id = id;
        Brand = brand;
        RegNumber = regNumber;
        BankAccount = bankAccount;
    }
}