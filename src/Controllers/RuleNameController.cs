using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dot.Net.WebApi.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Domain;
using WebApi.Dto.RuleName;
using WebApi.Repositories;

namespace Dot.Net.WebApi.Controllers
{
    [Route("[controller]")]
    public class RuleNameController : Controller
    {
        private readonly IRuleNameRepository _ruleNameRepository;

        public RuleNameController(IRuleNameRepository ruleNameRepository)
        {
            _ruleNameRepository = ruleNameRepository;
        }

        [HttpGet("/ruleName/list")]
        public async Task<IActionResult> Home()
        {
            var ruleNames = await _ruleNameRepository.GetAll();
            return Ok(ruleNames);
        }

        [HttpGet("/ruleName/add")]
        public IActionResult AddRuleName()
        {
            return Ok();
        }

        [HttpPost("/ruleName/add")]
        public async Task<IActionResult> Validate([FromBody] RuleName ruleName)
        {
            if (ModelState.IsValid)
            {
                await _ruleNameRepository.Add(ruleName);
                return Ok();
            }
            return Ok();
        }

        [HttpGet("/ruleName/update/{id}")]
        public async Task<IActionResult> ShowUpdateForm([FromBody] ShowUpdateFormDto input) 
        {
            var ruleName = await _ruleNameRepository.GetById(input.Id);
            if (ruleName == null)
            {
                return NotFound();
            }
            return Ok(ruleName);
        }

        [HttpPost("/ruleName/update/{id}")]
        public async Task<IActionResult> UpdateRuleName(int id, [FromBody] RuleName ruleName)
        {
            if (id != ruleName.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _ruleNameRepository.Update(ruleName);
                return Ok();
            }
            return Ok();
        }

        [HttpDelete("/ruleName/{id}")]
        public async Task<IActionResult> DeleteRuleName(int id)
        {
            await _ruleNameRepository.Delete(id);
            return Ok();
        }
    }

}