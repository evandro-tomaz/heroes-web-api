using HeroesWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace HeroesWebAPI.Context
{
    public class HeroesContext : DbContext
    {
        public HeroesContext(DbContextOptions<HeroesContext> options) : base(options)
        { }

        public DbSet<Heroes>? heroes { get; set; }
    }
}