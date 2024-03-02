using Domain.Entities;

namespace Domain.Interfaces;

public interface ICategoryRepository
{
    List<Category> GetAll();
    Category GetCategory(int id);
    bool Create(Category category);
    bool Update(Category category);
    bool Delete(Category category);
    
}