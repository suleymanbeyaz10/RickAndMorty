using RickAndMorty.Entities.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Domain.Entities;

public class FavoriteCharacters : BaseEntity
{
    public int CharacterId { get; set; }
    public Character Character { get; set; }
    public int UserId { get; set; }
    //public User User { get; set; }
}
