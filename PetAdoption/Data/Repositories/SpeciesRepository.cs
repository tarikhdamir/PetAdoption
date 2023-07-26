using PetAdoption.Data.Interfaces;
using PetAdoption.Data.Models;

namespace PetAdoption.Data.Repositories
{
    public class SpeciesRepository : ISpecies
    {
        private readonly AppDBContent _content;

        public SpeciesRepository(AppDBContent content)
        {
            _content = content;
        }
        public IEnumerable<Species> AllSpecies => _content.SpeciesTable;
    }
}
