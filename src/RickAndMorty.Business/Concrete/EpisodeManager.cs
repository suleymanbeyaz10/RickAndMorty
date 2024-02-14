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
    public class EpisodeManager : IEpisodeService
    {
        private IEpisodeDal _episodeDal;

        public EpisodeManager(IEpisodeDal episodeDal)
        {
            _episodeDal = episodeDal;
        }

        public IResult Add(Episode episode)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Episode episode)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Episode>> GetAll()
        {
            return new SuccessDataResult<List<Episode>>(_episodeDal.GetAll());
        }

        public IDataResult<Episode> GetById(int id)
        {
            return new SuccessDataResult<Episode>(_episodeDal.Get(p => p.Id == id));
        }

        public IResult Update(Episode episode)
        {
            throw new NotImplementedException();
        }
    }
}
