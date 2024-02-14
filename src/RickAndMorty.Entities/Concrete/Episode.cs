using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RickAndMorty.Entities.Concrete.Common;

namespace RickAndMorty.Domain.Entities;

public class Episode : BaseEntity
{
    public string? Name { get; set; }

    public string? AirDate { get; set; }

    public string? EpisodeCode { get; set; }

    public DateTime? Created { get; set; }

    public virtual ICollection<EpisodeCharacter> EpisodeCharacters { get; set; } = new List<EpisodeCharacter>();
    [NotMapped] // This tells EF to ignore the Characters property
    public List<string> Characters { get; set; }

}
