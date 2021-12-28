using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MarketContext _context;

        public TransactionRepository(MarketContext context)
        {
            this._context = context;
        }
        
        public IEnumerable<Transaction> Get(string cashierName)
        {
            return _context.Transactions.ToList();
        }

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return _context.Transactions.Where(x => x.TimeStamp.Date == date.Date);
            else
                return _context.Transactions.Where(x =>
                    EF.Functions.Like(x.CashierName, $"%{cashierName}%") &&
                    x.TimeStamp.Date == date.Date);
        }

        public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return _context.Transactions.Where(x => x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);
            else
                return _context.Transactions.Where(x =>
                    EF.Functions.Like(x.CashierName, $"%{cashierName}%") &&
                    x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);
        }

        public void Save(string cashierName, int productId, string productName, double price, int beforeQuantity, int soldQuantity)
        {
            var transaction = new Transaction
            {
                ProductId = productId,
                ProductName = productName,
                TimeStamp = DateTime.Now,
                Price = price,
                BeforeQuantity = beforeQuantity,
                SoldQuantity = soldQuantity,
                CashierName = cashierName
            };

            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }
    }
}
