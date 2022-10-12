using System.ComponentModel;
using System.Net.Mime;

namespace LearningCenter.Domain;

public class CategoryDomain : ICategoryDomain
{
    public List<string> getAll()
    {
        List<string> categories = new List<string>();
        categories.Add("old");
        categories.Add("new");
        categories.Add("used");
        return categories;
    }

    public string getCategoryById(int id)
    {
        return "body from v2 " + id.ToString();
    }

    public Boolean createCategory(string name)
    {
        return true;
    }

    public Boolean updateCategory(string name)
    {
        return true;
    }

    public Boolean deleteCategory(int id)
    {
        return true;
    }
}