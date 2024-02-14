using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RickAndMorty.Business.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodeCharactersController : ControllerBase
    {
        IEpisodeCharacterService _episodeCharacterService;

        public EpisodeCharactersController(IEpisodeCharacterService episodeCharacterService)
        {
            _episodeCharacterService = episodeCharacterService;
        }
        // get all
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _episodeCharacterService.GetAll();
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
            var result = _episodeCharacterService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
