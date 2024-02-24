using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dot.Net.WebApi.Controllers.Domain;
using Dot.Net.WebApi.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Repositories;

namespace Dot.Net.WebApi.Controllers
{
    [Route("[controller]")]
    public class RatingController : Controller
    {
        private readonly IRatingRepository _ratingRepository;

        public RatingController(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        [HttpGet("/rating/list")]
        public IActionResult Home()
        {
            var ratings = _ratingRepository.GetAll();
            return Ok(ratings);
        }

        [HttpPost("/rating/add")]
        public IActionResult AddRating([FromBody] Rating rating)
        {
            _ratingRepository.Add(rating);
            return Ok("Rating added successfully");
        }

        [HttpPost("/rating/update/{id}")]
        public IActionResult UpdateRating(int id, [FromBody] Rating rating)
        {
            var existingRating = _ratingRepository.GetById(id);
            if (existingRating == null)
            {
                return NotFound();
            }

            existingRating.MoodysRating = rating.MoodysRating;
            existingRating.SandPRating = rating.SandPRating;
            existingRating.FitchRating = rating.FitchRating;
            existingRating.OrderNumber = rating.OrderNumber;

            _ratingRepository.Update(existingRating);
            return Ok("Rating updated successfully");
        }

        [HttpDelete("/rating/{id}")]
        public IActionResult DeleteRating(int id)
        {
            var existingRating = _ratingRepository.GetById(id);
            if (existingRating == null)
            {
                return NotFound();
            }

            _ratingRepository.Delete(id);
            return Ok("Rating deleted successfully");
        }
    }
}