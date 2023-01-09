using RetailerWebAPI.Models;

namespace RetailerWebAPI.Repository.Interfaces
{
    public interface IRewardService
    {
        Rewards GetRewardsByCustomerId(long customerId);
    }
}
