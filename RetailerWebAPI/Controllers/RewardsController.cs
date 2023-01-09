using Microsoft.AspNetCore.Mvc;
using RetailerWebAPI.Models;
using RetailerWebAPI.Repository.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetailerWebAPI.Controllers
{
   
    
    [ApiController]
    public class RewardsController : ControllerBase
    {
        private readonly IRewardService _rewardService;

       public RewardsController(IRewardService rewardService)
        {
            _rewardService = rewardService;
        }

        // GET: api/<RewardsController>
        [HttpGet("api/customerreward/{customerId}")]

        public IActionResult GetRewardsByCustomerId(long customerId)
        {
           var rewardedCustomer = _rewardService.GetRewardsByCustomerId(customerId);
            if (rewardedCustomer != null)
                return Ok(new { data = rewardedCustomer });
            else
                return BadRequest();
        }

    
    }
}
