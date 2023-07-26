using Microsoft.EntityFrameworkCore;
using PetAdoption.Data.Models;

namespace PetAdoption.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) { }

        public DbSet<Pet> PetsTable { get; set; }
        public DbSet<Species> SpeciesTable { get; set; }
    }
}
