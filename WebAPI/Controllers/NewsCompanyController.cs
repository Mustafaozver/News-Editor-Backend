using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsCompanyController : ControllerBase
    {
        INewsCompanyServices _newsCompanyService;

        public NewsCompanyController(INewsCompanyServices newsCompanyService)
        {
            _newsCompanyService = newsCompanyService;

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _newsCompanyService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbynewsId")]
        public IActionResult GetById(int Id)
        {
            var result = _newsCompanyService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(NewsCompany newsCompany)
        {
            var result = _newsCompanyService.Add(newsCompany);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
