using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spovify.Application;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ISongService _songService;

        public SongsController(ISongService songService)
        {
            _songService = songService;
        }

        [HttpPost]
        public IActionResult Add(AddSongDto addSongDto)
        {
            _songService.Add(addSongDto);

            return Ok();
        }

        [HttpGet]
        public IActionResult List()
        {
            var data = _songService.List();

            return Ok(data);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var response = _songService.Delete(id);

            if (!response.IsSuccess)
                return NotFound(response.Error);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, UpdateSongDto updateSongDto)
        {
            var response = _songService.Update(id, updateSongDto);

            if (!response.IsSuccess)
                return NotFound(response.Error);

            return Ok();
        }
    }
}
