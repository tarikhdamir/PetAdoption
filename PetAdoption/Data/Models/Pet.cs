namespace PetAdoption.Data.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Species Species { get; set;}
        public int SpeciesId { get; set; }
        private int _age;
        public int Age
        {
            get => _age;
            private set { _age = value; }
        }
        private DateTime _birthDate;
        public DateTime BirthDate { 
            get => BirthDate;
            set {
                _birthDate = value;
                CalculateAge();
            } 
        }

        public void CalculateAge()
        {
            _age = new DateTime(DateTime.Now.Subtract(_birthDate).Ticks).Year;
        }

        public int Weight { get; set; }
        public int Height { get; set; }
        public string Img { get; set; }
        public string Sex { get; set; }
    }
}
