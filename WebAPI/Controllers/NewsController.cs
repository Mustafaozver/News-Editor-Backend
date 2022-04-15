using Business.Abstract;

using Entities.Concrete;

using Microsoft.AspNetCore.Mvc;
using SuperSimpleTcp;
using System.Text;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        INewsService _newsService;
        SimpleTcpClient client;


        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
            client = new("10.5.5.92:4480");

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _newsService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getbyeditor")]
        public IActionResult GetByEditor(int editorId)
        {
            var result = _newsService.GetDraftNewsByEditorId(editorId);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getdraftall")]
        public IActionResult getDraftAll(int editorId)
        {
            var result = _newsService.GetAllDraft();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getbyId")]
        public IActionResult GetById(int Id)
        {
            var result = _newsService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpGet("getNewsDetail")]
        public IActionResult GetNewsDeail()
        {
            var result = _newsService.GetNewsDetailDto();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }




        [HttpPost("add")]
        public IActionResult Add(News news)
        {
            var result = _newsService.Add(news);
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
        [HttpPost("update")]
        public IActionResult Update(News news)
        {
            var result = _newsService.Update(news);
            if (result.Success)
            {
                return Ok(result);


            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(News news)
        {
            var result = _newsService.Delete(news);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }




    }

}
