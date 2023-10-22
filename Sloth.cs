// Eric Sällström .NET23

namespace Labb6OOPArv
{
    // Sloth-klassen är en underklass till Animal-klassen.
    internal class Sloth : Animal
    {
        // Unik skyddad egenskap för denna klass
        // och eventuella underklasser.
        protected string _characteristic { get; set; }

        // Konstruktor med ärvda variabler från Animal-klassen.
        // Ett default-värde har tilldelats respektive variabel.
        // Samt den unika variabeln för denna klass.
        public Sloth(
            string name = "Ola",
            string gender = "Male",
            byte age = 43,
            string diet = "Omnivore",
            bool isEndangered = true,
            bool isExtinct = false,
            string characteristic = "Slothful"
        )
            : base(name, gender, age, diet, isEndangered, isExtinct)
        {
            _characteristic = characteristic;
        }

        // Nedan finns de fyra överskuggad publika metoder från 
        // basklassen med egen text anpassat för Sloth-klassen.
        public override void PresentAnimal()
        {
            base.PresentAnimal();
            Console.WriteLine($"* Characteristics: {_characteristic}");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()} goes: Aaah!");
        }

        public override void Eat()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()} is eating a cecropia leaf veeeeeeery slowly.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()} is sleeping after a long day hanging upside down.");
        }

        // Unik publik metod som endast återfinns i Sloth-klassen.
        public void Swim()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()} loves to swim!");
        }
    }
}