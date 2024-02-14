using Core.Utilities.Results;
using RickAndMorty.Business.Abstract;
using RickAndMorty.DataAccess.Abstract;
using RickAndMorty.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Business.Concrete
{
    public class EpisodeCharacterManager : IEpisodeCharacterService
    {
        private IEpisodeCharacterDal _episodeCharacterDal;

        public EpisodeCharacterManager(IEpisodeCharacterDal episodeCharacterDal)
        {
            _episodeCharacterDal = episodeCharacterDal;
        }

        public IDataResult<List<EpisodeCharacter>> GetAll()
        {
            return new SuccessDataResult<List<EpisodeCharacter>>(_episodeCharacterDal.GetAll());
        }

        public IDataResult<EpisodeCharacter> GetById(int id)
        {
            return new SuccessDataResult<EpisodeCharacter>(_episodeCharacterDal.Get(p => p.Id == id));
        }
    }
}
