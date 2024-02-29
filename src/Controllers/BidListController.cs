using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dot.Net.WebApi.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Dto.BidList;
using WebApi.Repositories;

namespace Dot.Net.WebApi.Controllers
{
    [Route("[controller]")]
    public class BidListController : Controller
    {
        private readonly IBidListRepository _bidListRepository;

        public BidListController(IBidListRepository bidListRepository)
        {
            _bidListRepository = bidListRepository;
        }

        [HttpGet("/")]
        public IActionResult Home()
        {
            return View("Home");
        }

        [HttpPost("/bidList/validate")]
        public IActionResult Validate([FromBody] BidList bidList)
        {
            if (ModelState.IsValid)
            {
                _bidListRepository.Add(bidList);
                _bidListRepository.SaveChanges();
                return Ok(bidList);
            }
            return BadRequest(ModelState);
        }

        [HttpGet("/bidList/update/{id}")]
        public IActionResult ShowUpdateForm([FromBody] ShowBidListForm input)
        {
            var bidList = _bidListRepository.GetById(input.Id);
            if (bidList == null)
            {
                return NotFound();
            }
            return View("bidList/update", bidList);
        }

        [HttpPost("/bidList/update/{id}")]
        public IActionResult UpdateBid(int id, [FromBody] BidList bidList)
        {
            if (ModelState.IsValid)
            {
                var existingBidList = _bidListRepository.GetById(id);
                if (existingBidList == null)
                {
                    return NotFound();
                }

                existingBidList.Account = bidList.Account;
                existingBidList.Type = bidList.Type;

                _bidListRepository.Update(existingBidList);
                _bidListRepository.SaveChanges();

                return Ok(existingBidList);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("/bidList/{id}")]
        public IActionResult DeleteBid(int id)
        {
            var bidList = _bidListRepository.GetById(id);
            if (bidList == null)
            {
                return NotFound();
            }

            _bidListRepository.Delete(id);
            _bidListRepository.SaveChanges();

            return NoContent();
        }
    }

}