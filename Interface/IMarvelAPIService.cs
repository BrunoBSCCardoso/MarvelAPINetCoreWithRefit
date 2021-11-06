using Refit;
using System.Threading.Tasks;

namespace CallMarvelAPIWithRefit.Interface
{
    public interface IMarvelAPIService
    {
        [Get("/v1/public/characters")]
        Task<object> GetCharacters();
    }
}
