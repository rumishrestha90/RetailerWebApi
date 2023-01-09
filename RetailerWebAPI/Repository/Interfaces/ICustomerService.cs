using RetailerWebAPI.Entities;

namespace RetailerWebAPI.Repository.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetCustomerAll();
        Customer GetCustomerById(long customerId);
    }
}
