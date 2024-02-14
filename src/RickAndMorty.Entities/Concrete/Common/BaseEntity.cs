using RickAndMorty.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Entities.Concrete.Common;

public class BaseEntity : IEntity
{
    public int Id { get; set; }
}
