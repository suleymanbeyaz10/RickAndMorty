using Core.Utilities.Results;
using RickAndMorty.Domain.Entities;

namespace RickAndMorty.Business.Abstract;

public interface IEpisodeService
{
    IResult Add(Episode episode);
    IResult Update(Episode episode);
    IResult Delete(Episode episode);
    IDataResult<List<Episode>> GetAll();
    IDataResult<Episode> GetById(int id);
}
