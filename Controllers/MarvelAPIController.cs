using CallMarvelAPIWithRefit.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CallMarvelAPIWithRefit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarvelAPIController : ControllerBase
    {
        private readonly IMarvelAPIService _marvelAPIService;

        public MarvelAPIController(IMarvelAPIService marvelAPIService)
        {
            _marvelAPIService = marvelAPIService ?? throw new ArgumentNullException(nameof(marvelAPIService));
        }

        public async Task<object> GetCharacteres()
        {
            return await _marvelAPIService.GetCharacters();
        }
    }
}
