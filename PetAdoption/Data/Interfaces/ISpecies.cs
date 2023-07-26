using PetAdoption.Data.Models;

namespace PetAdoption.Data.Interfaces
{
    public interface ISpecies
    {

        IEnumerable<Species> AllSpecies { get; }
    }
}
