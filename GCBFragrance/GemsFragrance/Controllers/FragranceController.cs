using GemsCore.IServices;
using GemsData.DTO;
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
    }
}
