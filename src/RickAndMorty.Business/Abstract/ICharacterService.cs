using Core.Utilities.Results;
using RickAndMorty.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Business.Abstract;

public interface ICharacterService
{
    IResult Add(Character character);
    IResult Update(Character character);
    IResult Delete(Character character);
    IDataResult<List<Character>> GetAll();
    IDataResult<Character> GetById(int id);
}
