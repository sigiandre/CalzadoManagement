using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.ProductsUseCases
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IProductRepository _productRepository;
        private readonly IRecordTransactionUseCase _recordTransactionUseCase;

        public SellProductUseCase(IProductRepository productRepository, IRecordTransactionUseCase recordTransactionUseCase)
        {
            this._productRepository = productRepository;
            this._recordTransactionUseCase = recordTransactionUseCase;
        }

        public void Execute(string cashierName, int productId, int quantityToSell)
        {
            var product = _productRepository.GetProductById(productId);
            if (product == null) return;

            _recordTransactionUseCase.Execute(cashierName, productId, quantityToSell);
            product.Quantity -= quantityToSell;
            _productRepository.UpdateProduct(product);
        }
    }
}
