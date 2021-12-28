using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.Transactions
{
    public class GetTransactionsUseCase : IGetTransactionsUseCase
    {
        private readonly ITransactionRepository _transactionRepository;

        public GetTransactionsUseCase(ITransactionRepository transactionRepository)
        {
            this._transactionRepository = transactionRepository;
        }

        public IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate)
        {
            return _transactionRepository.Search(cashierName, startDate, endDate);
        }
    }
}
