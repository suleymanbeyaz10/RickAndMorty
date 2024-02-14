using RickAndMorty.Entities.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Domain.Entities;

public class Character : BaseEntity
{
    public int Name { get; set; }
    public string Status { get; set; }
    public string Species { get; set; }
    public string Type { get; set; }
    public string Gender { get; set; }
    public string Image { get; set; }
    public List<Episode> Episodes { get; set; }
    public string Url { get; set; }
    public DateTime Created { get; set; }
}
