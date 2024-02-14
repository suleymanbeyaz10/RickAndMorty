using Core.DataAccess;
using RickAndMorty.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.DataAccess.Abstract;

public interface ICharacterDal : IEntityRepository<Character>
{
}
