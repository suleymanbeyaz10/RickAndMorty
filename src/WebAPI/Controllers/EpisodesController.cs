using Microsoft.AspNetCore.Mvc;
using RickAndMorty.Business.Abstract;

namespace WebAPI.Controllers
{
    public class EpisodesController : ControllerBase
    {
        IEpisodeService _episodeService;

        public EpisodesController(IEpisodeService episodeService)
        {
            _episodeService = episodeService;
        }

        // get all
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _episodeService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        // get by id 
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _episodeService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

    }
}
