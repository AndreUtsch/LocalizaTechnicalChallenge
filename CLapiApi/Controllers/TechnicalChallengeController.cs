using ClapiApi.Business;
using Microsoft.AspNetCore.Mvc;


namespace CLapiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnicalChallengeController : ControllerBase
    {

        [HttpGet]
        public string Get(string userEntry)
        {
            return new TechnicalChallengeBusiness().GetNumbers(userEntry);
        }

    }
}
