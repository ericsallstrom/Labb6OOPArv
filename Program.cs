// Eric Sällström .NET23

namespace Labb6OOPArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar en lista som lagrar de objekten jag skapar utifrån deras klass.
            List<Animal> animals = new List<Animal>()
            {
                new Tiger(),
                new Sloth(),
                new Spider(),
                new SaberToothedTiger(
                    name: "Amanda", gender: "Female",
                    age: 34, diet: "Carnevore",
                    mainFood: "Entrecôte", isEndangered: true,
                    isExtinct: true, toothLength: 16),
                new SiberianTiger(
                    name: "Coco", gender: "Female",
                    age: 70, diet: "Carnevore",
                    mainFood: "Wild boar", isEndangered: true,
                    isExtinct: false, sprintSpeed: 43),
                new Sloth(
                    name: "Lennart", gender: "Hermaphrodite",
                    age: 26, diet: "Omnivore",
                    isEndangered: true, isExtinct: false,
                    characteristic: "Yellow fur"),
                new Spider(
                    name: "Eva", gender: "Female",
                    age: 3, diet: "Carnevore",
                    isEndangered: false, isExtinct: false,
                    isPoisonous: true)
            };

            // Med en foreach-loop skriver jag ut alla djur-objekten som finns i listan animals
            // och tillhörande klassmetoder för respektive objekt. Alla objekt har en egen unik
            // metod som endast kan anropas direkt genom objektet för en specifik klass. Därav
            // if-satserna som kollar om animal stämmer överens med de olika djur-klasserna.
            foreach (Animal animal in animals)
            {
                animal.PresentAnimal();
                animal.MakeSound();
                animal.Eat();
                animal.Sleep();

                if (animal is Tiger tiger)
                {
                    tiger.Hunt();

                    if (animal is SaberToothedTiger saberTiger)
                    {
                        saberTiger.SharpenTeeth();
                    }
                    else if (animal is SiberianTiger siberianTiger)
                    {
                        siberianTiger.KeepWarm();
                    }
                }
                else if (animal is Spider spider)
                {
                    spider.Web();
                }
                else if (animal is Sloth sloth)
                {
                    sloth.Swim();
                }
                Console.WriteLine("---");
            }
        }
    }
}