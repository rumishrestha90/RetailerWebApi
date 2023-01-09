using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailerWebAPI.Repository.Interfaces;
using RetailerWebAPI.Entities;
using RetailerWebAPI.Models;

namespace RetailerWebAPI.Test.TestMethods
{
    public class CustomerReward
    {
        private readonly IRewardService _rewardService;

        public CustomerReward(IRewardService rewardService)
        {
            _rewardService = rewardService; 
        }

        [Test]
        public Rewards TestReward()
        {
            Rewards _rewardcustomers = new Rewards();
            _rewardcustomers.CustomerId = 1001;
            _rewardcustomers.LastMonthRewardPoints = 1000;
            _rewardcustomers.LastSecondMonthRewardPoints = 2000;
            _rewardcustomers.LastThirdMonthRewardPoints =3000;
            _rewardcustomers.TotalRewards = 5000;
            return _rewardcustomers;
        }

        [Test]
        public void TestCustomerReward()
        {
            var result = _rewardService.GetRewardsByCustomerId(1001);
            Assert.Equals(result,TestReward());
        }
    }
}
