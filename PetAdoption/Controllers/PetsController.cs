using Microsoft.AspNetCore.Mvc;
using PetAdoption.Data.Models;
using PetAdoption.Data.Interfaces;
using PetAdoption.VIewModels;
using PetAdoption.Views.Shared;
using System.Drawing.Printing;
using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata.Ecma335;

namespace PetAdoption.Controllers
{
    public class PetsController : Controller
    {
        private readonly IPet PetsList;
        private readonly ISpecies Species;
        public PetsController(IPet iAllPets, ISpecies iAllSpecies)
        {
            PetsList = iAllPets;
            Species = iAllSpecies;
        }
        public IActionResult Index()
        {
            foreach (var x in PetsList.AllPets)
            {
                Console.WriteLine(x);
            }
            return View(PetsList.AllPets);
        }
    }
}
