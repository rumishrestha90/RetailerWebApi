using RetailerWebAPI.Entities;
using RetailerWebAPI.Repository.Interfaces;


namespace RetailerWebAPI.Repository.Services
{
    public class TransactionService : ITransactionService
    {
        public List<Transaction> GetAllByCustomerId(long customerId)
        {
            return Data.TransactionData.GetTransactionData().Where(x=>x.CustomerId==customerId).ToList();
        }

        public List<Transaction> GetAllCustomerByIdAndTransactionDate(long customerId, DateTime from, DateTime to)
        {
            return Data.TransactionData.GetTransactionData().Where(x => x.CustomerId == customerId && x.TransactionDate >= from && x.TransactionDate <= to).ToList();
        }
    }
}
