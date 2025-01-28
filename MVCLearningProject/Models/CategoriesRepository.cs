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
            new Category{CategoryId = 4, Name="Trees", Description="Tree data structure"},
            new Category{CategoryId = 5, Name="Graphs", Description="Graph data structure"},
            new Category{CategoryId = 6, Name="Arrays", Description="Array data structure"},
            new Category{CategoryId = 7, Name="Trees", Description="Tree data structure"},
            new Category{CategoryId = 10, Name="Graphs", Description="Graph data structure"},
            new Category{CategoryId = 11, Name="Arrays", Description="Array data structure"},
            new Category{CategoryId = 12, Name="Trees", Description="Tree data structure"},
            new Category{CategoryId = 13, Name="Graphs", Description="Graph data structure"},
            new Category{CategoryId = 14, Name="Arrays", Description="Array data structure"},
            new Category{CategoryId = 15, Name="Trees", Description="Tree data structure"},
            new Category{CategoryId = 16, Name="Graphs", Description="Graph data structure"},
            new Category{CategoryId = 17, Name="Arrays", Description="Array data structure"},
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
        public static void UpdateCategory(int categoryId, Category category)
        {
            if (categoryId != category.CategoryId)
                return;
            var categoryToUpdate = _categories.FirstOrDefault(category => category.CategoryId == categoryId);
            if (categoryToUpdate !=null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
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
