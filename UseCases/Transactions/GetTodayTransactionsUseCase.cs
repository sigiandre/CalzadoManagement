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
    public class GetTodayTransactionsUseCase : IGetTodayTransactionsUseCase
    {
        private readonly ITransactionRepository _transactionRepository;

        public GetTodayTransactionsUseCase(ITransactionRepository transactionRepository)
        {
            this._transactionRepository = transactionRepository;
        }

        public IEnumerable<Transaction> Execute(string cashierName)
        {
            return _transactionRepository.GetByDay(cashierName, DateTime.Now);
        }
    }
}
