using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dot.Net.WebApi.Domain;
using Dot.Net.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
 
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
        public IActionResult FindTrades(int TradeId)
        {
            var result = _tradeRepository.FindTrade(TradeId);
            return Json(result);
        }

        [HttpGet("/trade/add")]
        public IActionResult AddTrade([FromBody]Trade trade)
        {
            var result = _tradeRepository.AddTrade(trade);
            return Json(result);
            
        }

        [HttpGet("/trade/add")]
        public IActionResult Validate([FromBody]Trade trade)
        {
            // TODO: check data valid and save to db, after saving return Trade list
            return View("trade/add");
        }

        [HttpGet("/trade/update/{id}")]
        public IActionResult ShowUpdateForm(int id)
        {
            // TODO: get Trade by Id and to model then show to the form
            return View("trade/update");
        }

        [HttpPost("/trade/update/{id}")]
        public IActionResult updateTrade(int id, [FromBody] Trade trade)
        {
            // TODO: check required fields, if valid call service to update Trade and return Trade list
            return Redirect("/trade/list");
        }

        [HttpDelete("/trade/{id}")]
        public IActionResult DeleteTrade(int id)
        {
            // TODO: Find Trade by Id and delete the Trade, return to Trade list
            return Redirect("/trade/list");
        }
    }
}