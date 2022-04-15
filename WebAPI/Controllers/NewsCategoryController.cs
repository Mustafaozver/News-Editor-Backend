using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsCategoryController : ControllerBase
    {
        INewsCategoriesService _newsCategoryService;

        public NewsCategoryController(INewsCategoriesService newsCategoryService)
        {
            _newsCategoryService = newsCategoryService;

        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _newsCategoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getbynewsId")]
        public IActionResult GetById(int Id)
        {
            var result = _newsCategoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(NewsCategories newsCategory)
        {
            var result = _newsCategoryService.Add(newsCategory);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

    }
}
