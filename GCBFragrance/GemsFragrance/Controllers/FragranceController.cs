using GemsCore.IServices;
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
        public ActionResult<List<Fragrance>> GetAllFragrances()
        {
            try
            {
                var fragrances = _fagranceService.GetAllFragrances().ToList();
                return Ok(fragrances);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
