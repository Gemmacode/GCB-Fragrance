using GCBCORE.IServices;
using GCBData.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GCBFragrance.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class FragranceController : ControllerBase
    {
        private readonly IFrangranceService _service;

        public FragranceController(IFrangranceService service)
        {
            _service = service;
        }

        [HttpPost("Add-Fragrance")]
        public IActionResult AddFragrance(FragranceDTO fragrance)
        {
            _service.AddFragrance(fragrance);
            return Ok("Fragrance Added Successfully");
        }

        //[HttpGet("Get-Fragrance-By-Id")]
        //public IActionResult GetFragranceById(string Id)
        //{

        //}
    }
}
