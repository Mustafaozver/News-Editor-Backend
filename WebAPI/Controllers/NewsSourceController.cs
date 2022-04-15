using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
  
        [Route("api/[controller]")]
        [ApiController]
        public class NewsSourceController : ControllerBase
        {

            INewsSourceService _newsSourceService;

            public NewsSourceController(INewsSourceService newsSourceService)
            {
                _newsSourceService = newsSourceService;

            }

            [HttpGet("getall")]
            public IActionResult GetAll()
            {
                var result = _newsSourceService.GetAll();
                if (result.Success)
                {
                    return Ok(result);

                }
                return BadRequest(result);
            }

            [HttpGet("getbynewsId")]
            public IActionResult GetById(int Id)
            {
                var result = _newsSourceService.GetById(Id);
                if (result.Success)
                {
                    return Ok(result);

                }
                return BadRequest(result);
            }
            [HttpPost("add")]
            public IActionResult Add(NewsSource newsSource)
            {
                var result = _newsSourceService.Add(newsSource);
                if (result.Success)
                {
                    return Ok(result);

                }
                return BadRequest(result);
            }

        }

    }

