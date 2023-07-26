using PetAdoption.Data.Models;

namespace PetAdoption.Data.Interfaces
{
    public interface IPet  
    {
        IEnumerable<Pet> AllPets { get; }

        public Pet getPet(int petId);
    }
}
