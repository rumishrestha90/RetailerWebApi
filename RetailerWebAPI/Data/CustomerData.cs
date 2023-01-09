using RetailerWebAPI.Entities;

namespace RetailerWebAPI.Data
{
    public static class CustomerData
    {
        public static List<Customer> GetCustomersData()
        {
            List<Customer> _customers = new List<Customer>();
            _customers.Add(new Customer() { CustomerId = 1001, CustomerName = "Customer1" });
            _customers.Add(new Customer() { CustomerId = 1002, CustomerName = "Customer2" });
            _customers.Add(new Customer() { CustomerId = 1003, CustomerName = "Customer3" });
            _customers.Add(new Customer() { CustomerId = 1004, CustomerName = "Customer4" });
            _customers.Add(new Customer() { CustomerId = 1005, CustomerName = "Customer5" });
            _customers.Add(new Customer() { CustomerId = 1006, CustomerName = "Customer6" });
            _customers.Add(new Customer() { CustomerId = 1007, CustomerName = "Customer7" });
            _customers.Add(new Customer() { CustomerId = 1008, CustomerName = "Customer8" });
            _customers.Add(new Customer() { CustomerId = 1009, CustomerName = "Customer9" });
            _customers.Add(new Customer() { CustomerId = 10010, CustomerName = "Customer10" });
            return _customers;
        }
    }
}
