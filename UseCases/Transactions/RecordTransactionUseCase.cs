using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.Transactions
{
    public class RecordTransactionUseCase : IRecordTransactionUseCase
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IGetProductByIdUseCase _getProductByIdUseCase;

        public RecordTransactionUseCase(ITransactionRepository transactionRepository, IGetProductByIdUseCase getProductByIdUseCase)
        {
            this._transactionRepository = transactionRepository;
            this._getProductByIdUseCase = getProductByIdUseCase;
        }

        public void Execute(string cashierName, int productId, int quantity)
        {
            var product = _getProductByIdUseCase.Execute(productId);
            _transactionRepository.Save(cashierName, productId, product.Name, product.Price.Value, product.Quantity.Value, quantity);
        }
    }
}
