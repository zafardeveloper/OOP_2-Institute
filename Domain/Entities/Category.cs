namespace Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public int Name { get; set; }
    public int Description { get; set; }

    public bool IsDeleted { get; set; } = false;
}