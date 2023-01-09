namespace RetailerWebAPI.Entities
{
    public class Transaction
    {
        public long TransactionId { get; set; }

        public long CustomerId { get; set; }

        public DateTime TransactionDate { get; set; }

        public double TransactionAmount { get; set; }


        public long getTransactionId()
        {
            return TransactionId;
        }

        public void setTransactionId(long transactionId)
        {
            this.TransactionId = transactionId;
        }

        public long getCustomerId()
        {
            return CustomerId;
        }

        public void setCustomerId(long customerId)
        {
            this.CustomerId = customerId;
        }

        public DateTime getTransactionDate()
        {
            return TransactionDate;
        }

        public void setTransactionDate(DateTime transactionDate)
        {
            this.TransactionDate = transactionDate;
        }

        public double getTransactionAmount()
        {
            return TransactionAmount;
        }

        public void setTransactionAmount(double transactionAmount)
        {
            this.TransactionAmount = transactionAmount;
        }
    }
}
