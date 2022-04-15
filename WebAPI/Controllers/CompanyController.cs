using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : Controller
    {
        ICompanyService _companyServices;

        public CompanyController(ICompanyService companyServices)
        {
            _companyServices = companyServices;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _companyServices.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbyId")]
        public IActionResult GetById(int Id)
        {
            var result = _companyServices.GetById(Id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Company company)
        {
            var result = _companyServices.Add(company);
            if (result.Success)
            {
                //    client.Connect();
                //    if (client.IsConnected)
                //    {
                //     var smesssage = news.Id+";"+ news.Headline + ";" + news.Body+";"+"AHaber";
                //     client.Send(smesssage);                   
                //    }

                return Ok(result);


            }
            return BadRequest(result);
        }
    }
}
