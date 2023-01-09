

using RetailerWebAPI.Entities;

namespace RetailerWebAPI.Repository.Interfaces
{
    public interface ITransactionService
    {
         List<Transaction> GetAllByCustomerId(long customerId);

         List<Transaction> GetAllCustomerByIdAndTransactionDate(long customerId, DateTime from, DateTime to);
    }
}
