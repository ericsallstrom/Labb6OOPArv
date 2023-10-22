// Eric Sällström .NET23

namespace Labb6OOPArv
{
    // SiberianTiger-klassen ärver från Tiger-klassen 
    // och Animal-klassen. Dvs. arv i två led.
    internal class SiberianTiger : Tiger
    {
        // Privat fält unikt för klassen med tillhörande
        // skyddad getter-och-setter-metod som kontrollerar
        // så att tophastigheten ej överstiger 60 km/h.
        private byte _sprintSpeed;
        protected byte SprintSpeed
        {
            get
            {
                return _sprintSpeed;
            }
            set
            {
                if (value > 60)
                {
                    _sprintSpeed = 60;
                }
                else
                {
                    _sprintSpeed = value;
                }
            }
        }

        // Konstruktor med ärvda variabler från Tiger- och 
        // Animal-klassen som tilldelas värdet från konstruktorns 
        // variabler, samt en specifik för denna klass.
        public SiberianTiger(string name, string gender, byte age, string diet,
            string mainFood, bool isEndangered, bool isExtinct, byte sprintSpeed)
            : base(name, gender, age, diet, mainFood, isEndangered, isExtinct)
        {
            SprintSpeed = sprintSpeed;
        }

        // Överskuggad metod som ärver koden från basklassens metod
        // samt presenterar värdet från klassens unika egenskap.
        public override void PresentAnimal()
        {
            base.PresentAnimal();
            Console.WriteLine($"* Top Speed: {SprintSpeed} km/h");
        }

        // Modifierad överskuggad metod från Animal-klassen 
        // som returnerar djurtypen från klassens namn.
        protected override string GetAnimalType()
        {
            string type = GetType().ToString();
            string firstWord = type.Substring(12, 8);
            string secondWord = type.Substring(20);
            string animalType = firstWord + " " + secondWord;
            return animalType;
        }

        // Unik publik metod (dvs. tillgänglig utanför denna klass).
        public void KeepWarm()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()} keeps warm during the extremely cold nights " +
                            $"\nin Russia with the help of its thick layer of fat and dense fur.");
        }
    }
}