using GemsCore.IServices;
using GemsCore.Services;
using GemsData.DTO;
using GemsModel.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GemsFragrance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FragranceController : ControllerBase
    {
        private readonly IFragranceService _fagranceService;

        public FragranceController(IFragranceService fagranceService)
        {
            _fagranceService = fagranceService;
        }

        [HttpPost("Create-Fragrance")]
        public IActionResult AddFragrance(FragranceDTO fragrance)
        {
            var result = _fagranceService.AddFragrance(fragrance);
            return Ok(result);
        }

        [HttpGet("Get-Fragrance-By-Id")]
        public IActionResult GetFragrance(string id)
        {
            var result = _fagranceService.GetFragranceById(id);
            return Ok(result);
        }

        [HttpGet("Get-All-Fragrance")]
        public ActionResult<IEnumerable<Fragrance>> GetAllFragrances()
        {
            try
            {
                var fragrances = _fagranceService.GetAllFragrances().ToList();
                return Ok(fragrances);
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("Delete-Fragrance")]

        public IActionResult DeleteFragrance(string id)
        {
            var result = _fagranceService.DeleteFragrance(id);
            return Ok(result);
        }

        [HttpPut("{Update-Fragrance-By-Id}")]
        public ActionResult<string> UpdateFragrance(string id, [FromBody] FragranceDTO updatedFragrance)
        {
            string result = _fagranceService.UpdateFragrance(id, updatedFragrance);

            if (result == "Fragrance not found")
            {
                return NotFound(result);
            }
            else if (result == "Error updating fragrance")
            {
                return StatusCode(500, result);
            }

            return Ok(result);
        }


    }
}
