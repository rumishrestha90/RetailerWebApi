using RetailerWebAPI.Entities;
using RetailerWebAPI.Repository.Interfaces;

namespace RetailerWebAPI.Repository.Services
{
    public class CustomerService : ICustomerService
    {
		
		public List<Customer> GetCustomerAll()
		{
			return Data.CustomerData.GetCustomersData();
		}

		public Customer GetCustomerById(long customerId)
		{
			return Data.CustomerData.GetCustomersData().FirstOrDefault(x => x.CustomerId == customerId);
		}
	}
}
