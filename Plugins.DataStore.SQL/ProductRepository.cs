using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class ProductRepository : IProductRepository
    {
        private readonly MarketContext _context;

        public ProductRepository(MarketContext context)
        {
            this._context = context;
        }
        
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.Find(productId);
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return _context.Products.Where(x => x.CategoryId == categoryId).ToList();
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            var prod = _context.Products.Find(product.ProductId);
            prod.CategoryId = product.CategoryId;
            prod.Name = product.Name;
            prod.Price = product.Price;
            prod.Quantity = product.Quantity;

            _context.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product == null) return;

            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}
