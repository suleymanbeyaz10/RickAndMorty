using Core.Utilities.Results;
using RickAndMorty.Domain.Entities;

namespace RickAndMorty.Business.Abstract;

public interface IEpisodeCharacterService
{
    IDataResult<List<EpisodeCharacter>> GetAll();
    IDataResult<EpisodeCharacter> GetById(int id);
}
