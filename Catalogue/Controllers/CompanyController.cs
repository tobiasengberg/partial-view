using Catalogue.Models.Entities;
using Catalogue.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Catalogue.Controllers;

public class CompanyController : Controller
{
    // GET
    public IActionResult Index()
    {
        List<Company> companies = new List<Company>();
        companies.Add(new Company(1, "Volvo", "923856-1009", "378797345"));
        companies.Add(new Company(2, "ABB", "301782-5344", "79872935"));

        List<CompanyViewModel> companyViews = new List<CompanyViewModel>();
        foreach (Company company in companies)
        {
            CompanyViewModel view = new CompanyViewModel(
                company.Id,
                company.Brand,
                company.RegNumber
                );
            companyViews.Add(view);
        }
        
        return View(companyViews);
    }
}