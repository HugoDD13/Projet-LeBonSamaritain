using LeBonSamaritain.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LeBonSamaritain.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET Last Ad Sale
        [HttpGet]
        public IActionResult GetLastAdSale()
        {
            var context = new MyContext();

            var ads = context.Ads.OrderBy(ads => ads.Date)
                .First(ads => ads.AdType.Id.Equals(1));

            return Ok(ads);
        }


        public IActionResult GetLastAdLoad()
        {
            var context = new MyContext();

            var ads = context.Ads.OrderBy(ads => ads.Date)
                .First(ads => ads.AdType.Id.Equals(2));

            return Ok(ads);
        }


        public IActionResult GetLastAdGift()
        {
            var context = new MyContext();

            var ads = context.Ads.OrderBy(ads => ads.Date)
                .First(ads => ads.AdType.Id.Equals(3));

            return Ok(ads);
        }
    }

}

