using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;

        public ProductInMemoryRepository()
        {
            //Agregar algunos productos predeterminados
            products = new List<Product>()
            {
                new Product { ProductId = 1, CategoryId = 1, Name = "CAMURGA NEGRO", Quantity = 100, Price = 21.00 },
                new Product { ProductId = 2, CategoryId = 2, Name = "POLIBADANA BEIGE", Quantity = 200, Price = 14.00 },
                new Product { ProductId = 3, CategoryId = 3, Name = "CARTONES LAMINADOS 4.5", Quantity = 162, Price = 25.00 },
                new Product { ProductId = 4, CategoryId = 4, Name = "CALZAPEG", Quantity = 210, Price = 150.00 },
                new Product { ProductId = 5, CategoryId = 5, Name = "MICA TRANSPARENTE", Quantity = 201, Price = 30.00 },
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(x => x.ProductId == productId);
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;
            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }
            products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
            }
        }

        public void DeleteProduct(int productId)
        {
            var productToDelete = GetProductById(productId);
            if (productToDelete != null) products.Remove(productToDelete);
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return products.Where(x => x.CategoryId == categoryId);
        }
    }
}
