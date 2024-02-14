using Microsoft.EntityFrameworkCore;
using RickAndMorty.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.DataAccess.Concrete.EntityFramework;

public class RickAndMortyDBContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RickAndMortys;Trusted_Connection=true");
    }

    public virtual DbSet<Character> Characters { get; set; }
    public virtual DbSet<Episode> Episodes { get; set; }
}
