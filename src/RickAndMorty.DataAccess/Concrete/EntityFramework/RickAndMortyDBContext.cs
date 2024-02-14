using Microsoft.EntityFrameworkCore;
using RickAndMorty.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.DataAccess.Concrete.EntityFramework;

public partial class RickAndMortyContext : DbContext
{
    public RickAndMortyContext()
    {
    }

    public RickAndMortyContext(DbContextOptions<RickAndMortyContext> options) : base(options)
    {
    }

    public virtual DbSet<Character> Characters { get; set; }

    public virtual DbSet<Episode> Episodes { get; set; }

    public virtual DbSet<EpisodeCharacter> EpisodeCharacters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //your connection string
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RickAndMorty;Trusted_Connection=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Character>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Characters_1");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Episode>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<EpisodeCharacter>(entity =>
        {
            entity.HasOne(d => d.Character).WithMany(p => p.EpisodeCharacters)
                .HasForeignKey(d => d.CharacterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EpisodeCharacters_Characters");

            entity.HasOne(d => d.Episode).WithMany(p => p.EpisodeCharacters)
                .HasForeignKey(d => d.EpisodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EpisodeCharacters_Episodes");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
