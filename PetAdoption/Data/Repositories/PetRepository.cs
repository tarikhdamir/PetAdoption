using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using PetAdoption.Data.Interfaces;
using PetAdoption.Data.Models;
using System.Drawing;

namespace PetAdoption.Data.Repositories
{
    public class PetRepository : IPet
    {
        private readonly AppDBContent _content;

        public PetRepository(AppDBContent content)
        {
            _content = content;
        }

        

        public IEnumerable<Pet> AllPets => _content.PetsTable.Include(p => p.Species);

        public Pet getPet(int petId)
        {
            return _content.PetsTable.FirstOrDefault(p => p.Id == petId);
        }
    }
}
