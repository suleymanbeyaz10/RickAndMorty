using Core.DataAccess;
using RickAndMorty.Domain.Entities;

namespace RickAndMorty.DataAccess.Abstract;

public interface IEpisodeDal : IEntityRepository<Episode>
{
}