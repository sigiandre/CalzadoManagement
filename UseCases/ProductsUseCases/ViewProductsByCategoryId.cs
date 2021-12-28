using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.ProductsUseCases
{
    public class ViewProductsByCategoryId : IViewProductsByCategoryId
    {
        private readonly IProductRepository _productRepository;

        public ViewProductsByCategoryId(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IEnumerable<Product> Execute(int categoryId)
        {
            return _productRepository.GetProductsByCategoryId(categoryId);
        }
    }
}
