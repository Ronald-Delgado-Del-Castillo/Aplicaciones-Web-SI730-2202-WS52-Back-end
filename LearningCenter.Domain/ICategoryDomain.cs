namespace LearningCenter.Domain;

public interface ICategoryDomain
{
    List<string> getAll();
    string getCategoryById(int id);
    Boolean createCategory(string name);
    Boolean updateCategory(string name);
    Boolean deleteCategory(int id);
}