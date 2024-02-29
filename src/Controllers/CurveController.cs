using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dot.Net.WebApi.Domain;
using Microsoft.AspNetCore.Mvc;
using WebApi.Dto.CurvePoint;

namespace Dot.Net.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurveController : ControllerBase
    {
        private readonly ICurvePointRepository _curvePointRepository;

        public CurveController(ICurvePointRepository curvePointRepository)
        {
            _curvePointRepository = curvePointRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<CurvePoint>>> GetAllCurvePoints()
        {
            var curvePoints = await _curvePointRepository.GetAllAsync();
            return Ok(curvePoints);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CurvePoint>> GetCurvePointById(int id)
        {
            var curvePoint = await _curvePointRepository.GetByIdAsync(id);
            if (curvePoint == null)
            {
                return NotFound();
            }
            return Ok(curvePoint);
        }

        [HttpPost]
        public async Task<ActionResult> AddCurvePoint(CurvePoint curvePoint)
        {
            await _curvePointRepository.AddAsync(curvePoint);
            return CreatedAtAction(nameof(GetCurvePointById), new { id = curvePoint.Id }, curvePoint);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCurvePoint(int id, CurvePoint curvePoint)
        {
            if (id != curvePoint.Id)
            {
                return BadRequest();
            }

            await _curvePointRepository.UpdateAsync(curvePoint);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCurvePoint([FromBody] DeleteCurvePoint input)
        {
            await _curvePointRepository.DeleteAsync(input.Id);
            return NoContent();
        }
    }
}
