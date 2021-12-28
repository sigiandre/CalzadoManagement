using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MarketContext _context;

        public CategoryRepository(MarketContext context)
        {
            this._context = context;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.Find(categoryId);
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            var cat = _context.Categories.Find(category.CategoryId);
            cat.Name = category.Name;
            cat.Description = category.Description;
            _context.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var category = _context.Categories.Find(categoryId);
            if (category == null) return;

            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}
