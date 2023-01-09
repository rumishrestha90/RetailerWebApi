using RetailerWebAPI.Entities;
using RetailerWebAPI.Models;
using RetailerWebAPI.Repository.Interfaces;

namespace RetailerWebAPI.Repository.Services
{
    public class RewardService : IRewardService
    {
		TransactionService transactionService = new TransactionService();
		public Rewards GetRewardsByCustomerId(long customerId)
		{

			DateTime lastMonthTimestamp = GetDateBasedOnOffSetDays(Constant.daysInMonths);
			DateTime lastSecondMonthTimestamp = GetDateBasedOnOffSetDays(2 * Constant.daysInMonths);
			DateTime lastThirdMonthTimestamp = GetDateBasedOnOffSetDays(3 * Constant.daysInMonths);

			List<Transaction> lastMonthTransactions = transactionService.GetAllCustomerByIdAndTransactionDate(
					customerId, lastMonthTimestamp,DateTime.Now);
			List<Transaction> lastSecondMonthTransactions = transactionService
					.GetAllCustomerByIdAndTransactionDate(customerId, lastSecondMonthTimestamp, lastMonthTimestamp);
			List<Transaction> lastThirdMonthTransactions = transactionService
					.GetAllCustomerByIdAndTransactionDate(customerId, lastThirdMonthTimestamp,
							lastSecondMonthTimestamp);

			long lastMonthRewardPoints = GetRewardsPerMonth(lastMonthTransactions);
			long lastSecondMonthRewardPoints = GetRewardsPerMonth(lastSecondMonthTransactions);
			long lastThirdMonthRewardPoints = GetRewardsPerMonth(lastThirdMonthTransactions);

			Rewards customerRewards = new Rewards();
			customerRewards.CustomerId = customerId;
			customerRewards.LastMonthRewardPoints= lastMonthRewardPoints;
			customerRewards.LastSecondMonthRewardPoints =lastSecondMonthRewardPoints;
			customerRewards.LastThirdMonthRewardPoints= lastThirdMonthRewardPoints;
			customerRewards.TotalRewards =lastMonthRewardPoints + lastSecondMonthRewardPoints + lastThirdMonthRewardPoints;

			return customerRewards;

		}

		private long GetRewardsPerMonth(List<Transaction> transactions)
		{
			var reward = 0.0D;
			foreach (Transaction transaction in transactions)
            {
				reward += CalculateRewards(transaction);
            }
			return (long) reward;
		}

		private double CalculateRewards(Transaction t)
		{
			if (t.getTransactionAmount() > Constant.firstRewardLimit && t.getTransactionAmount() <= Constant.secondRewardLimit)
			{
				return Math.Round(t.getTransactionAmount() - Constant.firstRewardLimit);
			}
			else if (t.getTransactionAmount() > Constant.secondRewardLimit)
			{
				return Math.Round(t.getTransactionAmount() - Constant.secondRewardLimit) * 2
						+ (Constant.secondRewardLimit - Constant.firstRewardLimit);
			}
			else
				return 0;

		}

		public DateTime GetDateBasedOnOffSetDays(int days)
		{
			return DateTime.Now.AddDays(-days);
		}

      
    }
}
