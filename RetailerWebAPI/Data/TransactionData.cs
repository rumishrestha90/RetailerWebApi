using RetailerWebAPI.Entities;

namespace RetailerWebAPI.Data
{
    public static class TransactionData
    {
        public static List<Transaction> GetTransactionData()
        {
            List<Transaction> transactionList = new List<Transaction>();
            transactionList.Add(new Transaction() { TransactionId = 1, CustomerId = 1001, TransactionAmount = 1000.00, TransactionDate =new DateTime(2023,01,01) });
            transactionList.Add(new Transaction() { TransactionId = 2, CustomerId = 1002, TransactionAmount = 2000.00, TransactionDate = new DateTime(2023, 01, 01) });
            transactionList.Add(new Transaction() { TransactionId = 3, CustomerId = 1003, TransactionAmount = 3000.00, TransactionDate = new DateTime(2023, 01, 02) });
            transactionList.Add(new Transaction() { TransactionId = 4, CustomerId = 1004, TransactionAmount = 4000.00, TransactionDate = new DateTime(2023, 01, 03) });
            transactionList.Add(new Transaction() { TransactionId = 5, CustomerId = 1005, TransactionAmount = 5000.00, TransactionDate = new DateTime(2023, 01, 02) });
            transactionList.Add(new Transaction() { TransactionId = 6, CustomerId = 1006, TransactionAmount = 1000.00, TransactionDate = new DateTime(2023, 01, 01) });
            transactionList.Add(new Transaction() { TransactionId = 7, CustomerId = 1007, TransactionAmount = 2000.00, TransactionDate = new DateTime(2023, 01, 01) });
            transactionList.Add(new Transaction() { TransactionId = 8, CustomerId = 1008, TransactionAmount = 3000.00, TransactionDate = new DateTime(2023, 01, 02) });
            transactionList.Add(new Transaction() { TransactionId = 9, CustomerId = 1009, TransactionAmount = 4000.00, TransactionDate = new DateTime(2023, 01, 03) });
            transactionList.Add(new Transaction() { TransactionId = 10, CustomerId = 10010, TransactionAmount = 5000.00, TransactionDate = new DateTime(2022, 01, 02) });
            transactionList.Add(new Transaction() { TransactionId = 11, CustomerId = 1001, TransactionAmount = 1000.00, TransactionDate = new DateTime(2022, 12, 09) });
            transactionList.Add(new Transaction() { TransactionId = 12, CustomerId = 1002, TransactionAmount = 2000.00, TransactionDate = new DateTime(2023, 01, 01) });
            transactionList.Add(new Transaction() { TransactionId = 13, CustomerId = 1003, TransactionAmount = 3000.00, TransactionDate = new DateTime(2022, 09, 02) });
            transactionList.Add(new Transaction() { TransactionId = 14, CustomerId = 1004, TransactionAmount = 4000.00, TransactionDate = new DateTime(2023, 01, 03) });
            transactionList.Add(new Transaction() { TransactionId = 15, CustomerId = 1005, TransactionAmount = 5000.00, TransactionDate = new DateTime(2022, 01, 02) });
            transactionList.Add(new Transaction() { TransactionId = 16, CustomerId = 1001, TransactionAmount = 1000.00, TransactionDate = new DateTime(2022, 11, 09) });
            transactionList.Add(new Transaction() { TransactionId = 17, CustomerId = 1002, TransactionAmount = 2000.00, TransactionDate = new DateTime(2023, 01, 01) });
            transactionList.Add(new Transaction() { TransactionId = 18, CustomerId = 1003, TransactionAmount = 3000.00, TransactionDate = new DateTime(2023, 01, 02) });
            transactionList.Add(new Transaction() { TransactionId = 19, CustomerId = 1004, TransactionAmount = 4000.00, TransactionDate = new DateTime(2022, 01, 03) });
            transactionList.Add(new Transaction() { TransactionId = 20, CustomerId = 1005, TransactionAmount = 5000.00, TransactionDate = new DateTime(2022, 01, 20) });
            return transactionList;
        }
    }
}
