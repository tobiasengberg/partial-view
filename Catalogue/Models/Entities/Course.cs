namespace Catalogue.Models.Entities;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Code { get; set; }
    public Person Teacher { get; set; }
}