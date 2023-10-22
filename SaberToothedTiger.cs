// Eric Sällström .NET23

using System.Text;

namespace Labb6OOPArv
{
    // SaberToothedTiger-klassen ärver från Tiger-klassen 
    // och Animal-klassen. Dvs. arv i två led.
    internal class SaberToothedTiger : Tiger
    {
        // Unikt privat fält för denna klass med tillhörande
        // skyddad getter-och-setter-metod som kontrollerar
        // att längden på sabeltanden ej överstiger 18 cm.
        private byte _toothLength;
        protected byte ToothLength
        {
            get
            {
                return _toothLength;
            }
            set
            {
                if (value > 18)
                {
                    _toothLength = 18;
                }
                else
                {
                    _toothLength = value;
                }
            }
        }

        // Konstruktor med ärvda variabler från Tiger- och 
        // Animal-klassen som tilldelas värdet från konstruktorns 
        // variabler, samt en specifik för denna klass.
        public SaberToothedTiger(string name, string gender, byte age, string diet,
            string mainFood, bool isEndangered, bool isExtinct, byte toothLength)
            : base(name, gender, age, diet, mainFood, isEndangered, isExtinct)
        {
            ToothLength = toothLength;
        }

        // Överskuggad metod som ärver koden från basklassens 
        // metod plus värdet av klassens unika egenskap.
        public override void PresentAnimal()
        {
            base.PresentAnimal();
            Console.WriteLine($"* Tooth Length: {ToothLength} cm");
        }

        // Modifierad överskuggad metod från Animal-klassen 
        // som returnerar djurtypen från klassens namn.
        protected override string GetAnimalType()
        {
            string type = GetType().ToString();            
            string firstWord = type.Substring(12, 5);
            string secondWord = type.Substring(17, 7);
            string thirdWord = type.Substring(24);
            string animalType = firstWord + " " + secondWord + " " + thirdWord;
            return animalType;
        }

        // Unik publik metod (dvs. tillgänglig utanför klassen) som endast återfinns i denna klass.
        public void SharpenTeeth()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()} is sharpening its teeth. Watch out!");
        }
    }
}