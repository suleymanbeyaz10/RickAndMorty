using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RickAndMorty.Entities.Concrete.Common;

namespace RickAndMorty.Domain.Entities;

public class Episode : BaseEntity
{
    public string Name { get; set; }
    public string AirDate { get; set; }
    public string EpisodeCode { get; set; }
    public List<Character> Characters { get; set; }
    public string Url { get; set; }
    public DateTime Created { get; set; }

}
