// Eric Sällström .NET23

namespace Labb6OOPArv
{
    // Spider-klassen är en underklass till Animal-klassen.
    internal class Spider : Animal
    {
        // Unik skyddad egenskap för denna klass
        // och eventuella underklasser.
        protected bool _isPoisonous { get; set; }

        // Konstruktor med ärvda variabler från Animal-klassen.
        // Ett default-värde har tilldelats respektive variabel.
        // Samt den unika variabeln för denna klass.
        public Spider(
            string name = "Clarisse",
            string gender = "Female",
            byte age = 6,
            string diet = "Carnevore",
            bool isEndangered = false,
            bool isExtinct = false,
            bool isPoisonous = true
        )
            : base(name, gender, age, diet, isEndangered, isExtinct)
        {
            _isPoisonous = isPoisonous;
        }

        // Nedan finns de fyra överskuggade publika metoder från 
        // basklassen med egen text anpassat för Spider-klassen.
        public override void PresentAnimal()
        {
            base.PresentAnimal();
            Console.WriteLine($"* Poisonous: {BoolToString(_isPoisonous)}");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()} goes: zhzhzhz...");
        }

        public override void Eat()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()} is eating a big juicy fly.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()} is sleeping in its web.");
        }

        // Unik publik metod som endast återfinns i Spider-klassen.
        public void Web()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()} is making a web to catch som food...");
        }
    }
}