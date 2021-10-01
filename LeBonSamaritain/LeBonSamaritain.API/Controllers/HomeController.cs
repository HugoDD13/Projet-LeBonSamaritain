using LeBonSamaritain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LeBonSamaritain.API.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {


        [HttpGet("AllAdSale")]
        public IActionResult GetAllAdSale()
        {
            var context = new DataContext();

            var ads = context.Ads.OrderByDescending(ads => ads.Date)
                .Where(ads => ads.AdType.Id.Equals(1))
                .Select(ads => new { ads.Description, ads.Picture, ads.Price });

            return Ok(ads);
        }
        [HttpGet("LastAdSale")]
        public IActionResult GetLastAdSale()
        {
            var context = new DataContext();

            var ads = context.Ads.OrderByDescending(ads => ads.Date)
                .Where(ads => ads.AdType.Id.Equals(1))
                .Select(ads => new { ads.Description, ads.Picture, ads.Price })
                .First();

            return Ok(ads);
        }



        [HttpGet("LastAdLoad")]
        public IActionResult GetLastAdLoad()
        {
            var context = new DataContext();

            var ads = context.Ads.OrderByDescending(ads => ads.Date)
                .Where(ads => ads.AdType.Id.Equals(2))
                .Select(ads => new { ads.Description, ads.Picture })
                .First();

            return Ok(ads);
        }
        [HttpGet("AllAdLoad")]
        public IActionResult GetAllAdLoad()
        {
            var context = new DataContext();

            var ads = context.Ads.OrderByDescending(ads => ads.Date)
                .Where(ads => ads.AdType.Id.Equals(2))
                .Select(ads => new { ads.Description, ads.Picture });

            return Ok(ads);
        }



        [HttpGet("LastAdGift")]
        public IActionResult GetLastAdGift()
        {
            var context = new DataContext();

            var ads = context.Ads.OrderByDescending(ads => ads.Date)
                .Where(ads => ads.AdType.Id.Equals(3))
                .Select(ads => new { ads.Description, ads.Picture })
                .First();

            return Ok(ads);
        }
        [HttpGet("AllAdGift")]
        public IActionResult GetAllAdGift()
        {
            var context = new DataContext();

            var ads = context.Ads.OrderByDescending(ads => ads.Date)
                .Where(ads => ads.AdType.Id.Equals(3))
                .Select(ads => new { ads.Description, ads.Picture });

            return Ok(ads);
        }


    }

}

