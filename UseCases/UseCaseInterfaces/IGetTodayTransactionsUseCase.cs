using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces
{
    public interface IGetTodayTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName);
    }
}