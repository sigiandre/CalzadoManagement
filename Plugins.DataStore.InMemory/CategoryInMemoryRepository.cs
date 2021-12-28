using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
            //Agregar algunas categorías predeterminadas
            categories = new List<Category>()
            {
                new Category { CategoryId = 1, Name = "Cueros Sinteticos", Description = "Cueros Sinteticos" },
                new Category { CategoryId = 2, Name = "Forros Sinteticos", Description = "Forros Sinteticos" },
                new Category { CategoryId = 3, Name = "Cartones", Description = "Cartones" },
                new Category { CategoryId = 4, Name = "Pegamentos", Description = "Pegamentos" },
                new Category { CategoryId = 5, Name = "Micas", Description = "Micas" }
            };
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            if(categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }
            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public void DeleteCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }
    }
}
