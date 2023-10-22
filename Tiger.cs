// Eric Sällström .NET23

namespace Labb6OOPArv
{
    // Klassen Tiger ärver från klassen Animal.
    internal class Tiger : Animal
    {
        // Unik egenskap för Tiger-klassen
        protected string _mainFood { get; set; }

        // Konstruktor med ärvda variabler från basklassen
        // Animal som tilldelas värdet från konstruktorns 
        // variabler, samt en specifik för Tiger-klassen.
        public Tiger(
            string name = "Tony",
            string gender = "Male",
            byte age = 1,
            string diet = "Carnivore",
            string mainFood = "Red deer",
            bool isEndangered = true,
            bool isExtinct = false
        )
            : base(name, gender, age, diet, isEndangered, isExtinct)
        {
            _mainFood = mainFood;
        }

        // Nedan finns de fyra överskuggade publika metoder från 
        // basklassen med egen text anpassat för Tiger-klassen.
        public override void PresentAnimal()
        {
            base.PresentAnimal();
            Console.WriteLine($"* Favourite Meal: {_mainFood}");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()} goes: Roar!");
        }

        public override void Eat()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()} devours a {_mainFood.ToLower()}.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()} is tired and will sleep now...");
        }

        // Unik metod som endast återfinns i Tiger-klassen och dess underklasser.
        public virtual void Hunt()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()} hunts down and kills a {_mainFood.ToLower()}!");
        }
    }
}