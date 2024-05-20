using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spovify.Application;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistService _artistService;

        public ArtistsController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpPost]
        public IActionResult Add(AddArtistDto addArtistDto)
        {
            _artistService.Add(addArtistDto);

            return Ok();
        }
    }
}
