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
    public class ViewProductsUseCase : IViewProductsUseCase
    {
        private readonly IProductRepository _productRepository;

        public ViewProductsUseCase(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IEnumerable<Product> Execute()
        {
            return _productRepository.GetProducts();
        }
    }
}
