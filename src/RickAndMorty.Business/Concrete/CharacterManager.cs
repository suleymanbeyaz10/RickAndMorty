using Core.Utilities.Results;
using RickAndMorty.Business.Abstract;
using RickAndMorty.Domain.Entities;
using RickAndMorty.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RickAndMorty.DataAccess.Concrete.EntityFramework;

namespace RickAndMorty.Business.Concrete;

public class CharacterManager : ICharacterService
{
    ICharacterDal _characterDal;

    public CharacterManager(ICharacterDal characterDal)
    {
        
        _characterDal = characterDal;
    }

    public IResult Add(Character character)
    {
        throw new NotImplementedException();
    }

    public IResult Delete(Character character)
    {
        throw new NotImplementedException();
    }

    public IDataResult<List<Character>> GetAll()
    {
       return new SuccessDataResult<List<Character>>(_characterDal.GetAll());
    }

    public IDataResult<Character> GetById(int id)
    {
        return new SuccessDataResult<Character>(_characterDal.Get(p => p.Id == id));
    }

    public IResult Update(Character character)
    {
        throw new NotImplementedException();
    }
}
