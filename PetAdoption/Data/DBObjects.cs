using PetAdoption.Controllers;
using PetAdoption.Data.Models;
using System.Xml.Serialization;

namespace PetAdoption.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            if(!content.SpeciesTable.Any())
            {
                content.SpeciesTable.AddRange(Species.Select(c => c.Value));
            }
            if (!content.PetsTable.Any())
            {
                content.PetsTable.AddRange(Pets.Select(c => c.Value));
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Species> species;
        public static Dictionary<string, Species> Species
        {
            get
            {
                if (species == null)
                {
                    var list = new Species[]
                    {
                        new Species { SpeciesName = "Labrador Retriever", SpeciesDescription = "The sweet-faced, lovable Labrador Retriever is America's most popular dog breed."},
                        new Species { SpeciesName = "Golden Retriever", SpeciesDescription = "The intelligent and loyal Golden Retriever is a popular family pet known for its friendly and gentle nature."},
                        new Species { SpeciesName = "Pembroke Welsh Corgi", SpeciesDescription = "Among the most agreeable of all small housedogs, the Pembroke Welsh Corgi is a strong, athletic, and lively little herder who is affectionate and companionable without being needy."},
                        new Species { SpeciesName = "German Shepherd", SpeciesDescription = "The German Shepherd is a courageous and highly trainable breed, known for its protective instincts and versatility in various roles."},
                        new Species { SpeciesName = "French Bulldog", SpeciesDescription = "The adorable and affectionate French Bulldog is a small breed with a big personality, often described as a 'clown in a lapdog.'"},
                        new Species { SpeciesName = "Beagle", SpeciesDescription = "The Beagle is a friendly and curious breed known for its excellent sense of smell and playful nature."},
                        new Species { SpeciesName = "Siberian Husky", SpeciesDescription = "The Siberian Husky is a beautiful and energetic breed with a strong desire to run and explore."},
                        new Species { SpeciesName = "Poodle", SpeciesDescription = "The Poodle is an intelligent and elegant breed known for its curly coat and trainable nature."}

                    };

                    species = new Dictionary<string, Species>();
                    foreach (var item in list)
                    {
                        species.Add(item.SpeciesName, item);
                    }
                }
                return species;
            }
        }

        private static Dictionary<string, Pet> pets;

        private static Dictionary<string, Pet> Pets
        {
            get
            {
                if(pets == null)
                {
                    var list = new Pet[]
                    {
                        new Pet { Name = "Bob", Sex = "Male", BirthDate = new DateTime(2022, 05, 29), Species = Species["Labrador Retriever"], Weight = 30, Height = 60, Img = "/img/Bob.jpg" },
                        new Pet { Name = "Luna", Sex = "Female", BirthDate = new DateTime(2023, 01, 02), Species = Species["Labrador Retriever"], Weight = 25, Height = 55, Img = "/img/Luna.jpg" },
                        new Pet { Name = "Daisy", Sex = "Female", BirthDate = new DateTime(2022, 07, 02), Species = Species["Pembroke Welsh Corgi"], Weight = 13, Height = 28, Img = "/img/Daisy.jpg" },
                        new Pet { Name = "Bailey", Sex = "Female", BirthDate = new DateTime(2022, 01, 10), Species = Species["Labrador Retriever"], Weight = 28, Height = 58, Img = "/img/Bailey.jpg" },
                        new Pet { Name = "Max", Sex = "Male", BirthDate = new DateTime(2022, 09, 05), Species = Species["Golden Retriever"], Weight = 32, Height = 62, Img = "/img/Max.jpg" },
                        new Pet { Name = "Bella", Sex = "Female", BirthDate = new DateTime(2022, 03, 20), Species = Species["German Shepherd"], Weight = 35, Height = 65, Img = "/img/Bella.jpg" },
                        new Pet { Name = "Charlie", Sex = "Male", BirthDate = new DateTime(2022, 11, 12), Species = Species["French Bulldog"], Weight = 22, Height = 30, Img = "/img/Charlie.jpg" },
                        new Pet { Name = "Lucy", Sex = "Female", BirthDate = new DateTime(2022, 08, 15), Species = Species["Beagle"], Weight = 20, Height = 40, Img = "/img/Lucy.jpg" },
                        new Pet { Name = "Rocky", Sex = "Male", BirthDate = new DateTime(2022, 04, 02), Species = Species["Siberian Husky"], Weight = 45, Height = 55, Img = "/img/Rocky.jpg" },
                        new Pet { Name = "Lola", Sex = "Female", BirthDate = new DateTime(2022, 12, 25), Species = Species["Poodle"], Weight = 15, Height = 25, Img = "/img/Lola.jpg" }
                    };
                    pets = new Dictionary<string, Pet>();
                    foreach (var item in list)
                    {
                        item.CalculateAge();
                        pets.Add(item.Name, item);
                    }
                }
                return pets;
            }
        }
    }
}
