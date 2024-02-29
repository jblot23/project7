using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dot.Net.WebApi.Domain;
using Dot.Net.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Dto;
using WebApi.Dto.Trade;

namespace Dot.Net.WebApi.Controllers
{
    [Route("[controller]")]
    public class TradeController : Controller
    {
        // TODO: Inject Trade service
        private readonly ITradeRepository _tradeRepository;
        public TradeController(ITradeRepository tradeRepository) 
        {
            _tradeRepository = tradeRepository;
        }

        [HttpGet("/trade/list")]
        public IActionResult Home()
        {
            // TODO: find all Trade, add to model
            var result = _tradeRepository.GetAllTrades();
            return Json(result);
        }

        [HttpGet("/trade/GetTrade")]
        public IActionResult FindTrades([FromBody] FindTradeDto input)
        {
            var result = _tradeRepository.FindTrade(input.Id);
            return Json(result);
        }

        [HttpPost("/trade/add")]
        public IActionResult AddTrade([FromBody]Trade trade)
        {
            var result = _tradeRepository.AddTrade(trade);
            return Json(result);
            
        }

        [HttpPost("/trade/validateAdd")]
        public IActionResult Validate([FromBody]Trade trade)
        {
            if(trade.Status != "Open")
            {
                return BadRequest("You have enterted invliad data");
            }

            if(trade.Benchmark != "SM") 
            {
                return BadRequest("You have the wrong benchmark");
            }

            return View("trade/add");
        }

        [HttpGet("/trade/update/{id}")]
        public IActionResult ShowUpdateForm(int id)
        {
            // TODO: get Trade by Id and to model then show to the form
            return View("trade/update");
        }

        [HttpPost("/trade/update")]
        public IActionResult updateTrade(int id, [FromBody] Trade trade)
        {
            var response =  _tradeRepository.UpdateTrade(id, trade);
            return Ok(response);
        }

        [HttpDelete("/trade/{id}")]
        public IActionResult DeleteTrade(int id)
        {
            var response = _tradeRepository.DeleteTrade(id);
            return Ok(response);
        }

        [HttpPost("/trade/assign")]
        public IActionResult AssignEamil([FromBody] TradeDto input)
        {

            return Ok(input);   
        }
    }
}