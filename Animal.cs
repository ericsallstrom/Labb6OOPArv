// Eric Sällström .NET23

namespace Labb6OOPArv
{
    // Klassen Animal är basklassen från vilken de övriga klasserna 
    // klasserna ärver ifrån. Animal är även satt som abstrakt vilket
    // gör att man inte kan instantiera ett objekt av klassen.
    internal abstract class Animal
    {
        // Följande egenskaper använder "protected" som 
        // åtkomstmodifierare så att de kan ärvas av underklasserna 
        // men ej nås av användaren utanför bas- och underklasserna.
        protected string _name { get; set; }
        protected byte _age { get; set; }
        protected string _diet { get; set; }
        protected bool _isEndangered { get; set; }
        protected bool _isExtinct { get; set; }

        // Ett privat fält med tillhörande skyddad getter och setter som 
        // checkar om värdet är male, female eller hermaphrodite.
        // Annars tilldelas variabeln _gender ett default-värde.
        private string? _gender;
        protected string Gender
        {
            get
            {
                return _gender!;
            }
            set
            {
                if (value.ToLower() == "male")
                {
                    _gender = "Male";
                }
                else if (value.ToLower() == "female")
                {
                    _gender = "Female";
                }
                else if (value.ToLower() == "hermaphrodite")
                {
                    _gender = "Hermaphrodite";
                }
                else
                {
                    _gender = "Unspecified";
                }
            }
        }

        // Konstruktor som underklasserna måste ärva med
        // default-värde för varje enskild variabel.
        public Animal(
            string name = "Tarzan",
            string gender = "Male",
            byte age = 5,
            string diet = "Omnivore",
            bool isEndangered = false,
            bool isExtinct = false
        )
        {
            _name = name;
            Gender = gender;
            _age = age;
            _diet = diet;
            _isEndangered = isEndangered;
            _isExtinct = isExtinct;
        }

        // En virtuell metod som skriver ut info om ett specifikt 
        // djur. Eftersom metoden är virtuell kan även underklasserna 
        // ärva och modifiera den om de vill och modifiera. 
        public virtual void PresentAnimal()
        {
            Console.WriteLine($"\n{_name} the {GetAnimalType().ToLower()}" +
                              $"\n---" +
                              $"\n* Gender: {Gender}" +
                              $"\n* Age: {_age}" +
                              $"\n* Diet: {_diet}" +
                              $"\n* Endangered: {BoolToString(_isEndangered)}" +
                              $"\n* Extinct: {BoolToString(_isExtinct)}");
        }

        // En virtuell metod som förtkortar klasstypens namn i 
        // projektet och plockar endast ut djurnnamnet för klassen
        // (ex. Tiger istället för Labb6OOPArv.Tiger). Metoden
        // retunerar sedan namnet i en stringvariabel.
        protected virtual string GetAnimalType()
        {
            string type = GetType().ToString();
            char firstLetter = type[12];
            string animalType = firstLetter + type[13..];
            return animalType;
        }

        // Metoden används för att göra om en bool-variabel
        // till string och om variabeln visar true returneras
        // Yes och No om variebeln visar false. Detta för att
        // skriva ut en mer begriplig presentation av djuren.
        protected string BoolToString(bool answer)
        {
            if (answer.ToString() == "True")
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        // Tre abstrakta metoder utan kropp som underklasserna måste ärva.
        public abstract void MakeSound();
        public abstract void Eat();
        public abstract void Sleep();
    }
}