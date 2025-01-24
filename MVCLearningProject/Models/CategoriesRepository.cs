using System.Net;

namespace MVCLearningProject.Models
{
    public static class CategoriesRepository
    {
        private static List<Category> _categories = new List<Category>()
            {
            new Category{CategoryId = 1, Name="Trees", Description="Tree data structure"},
            new Category{CategoryId = 2, Name="Graphs", Description="Graph data structure"},
            new Category{CategoryId = 3, Name="Arrays", Description="Array data structure"},
            };
        public static void AddCategory(Category category)
        {
            var nextID = _categories.Max(c => c.CategoryId);
            category.CategoryId = nextID + 1;
            _categories.Add(category);
        }

        public static List<Category> GetCategories() => _categories;
        public static Category? GetCategory(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if(category !=null)
            {
                return new Category
                {
                    CategoryId = category.CategoryId,
                    Name = category.Name,
                    Description = category.Description,
                };
            }
            return null;

        }

        public static void DeleteCategory(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if (category != null) 
            {
                _categories.Remove(category);
            }

        }

        
    }
}
