﻿using Core.DataAccess.EntityFramework;
using RickAndMorty.DataAccess.Abstract;
using RickAndMorty.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.DataAccess.Concrete.EntityFramework;
                                                          
public class EfCharacterDal : EfEntityRepositoryBase<Character, RickAndMortyDBContext>, ICharacterDal
{
}