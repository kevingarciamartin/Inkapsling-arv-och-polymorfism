using Inkapsling__arv_och_polymorfism.Inkapsling;
using Inkapsling__arv_och_polymorfism.Polymorfism;
using Inkapsling__arv_och_polymorfism.Arv;
using Inkapsling__arv_och_polymorfism;

// 3.1
Console.WriteLine("3.1");
Console.WriteLine("---");

try
{
    PersonHandler personHandler = new();

    Person person1 = personHandler.CreatePerson(28, "Kevin", "Garcia Martin", 1.94, 95);
    Person person2 = personHandler.CreatePerson(0, "Baby", "Blue", 0.45, 0.41);
    Person person3 = personHandler.CreatePerson(77, "B", "Larsson", 1.63, 78);
    Person person4 = personHandler.CreatePerson(52, "Anja", "Peeeeeeeeeeeeeeeeeeeeeeeeeeersson", 1.72, 80);
}
catch (ArgumentException aex)
{
    //Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(aex.Message);
    //Console.WriteLine(aex.StackTrace);
}
finally
{
    Console.ResetColor();
}

Console.WriteLine();

// 3.2
Console.WriteLine("3.2");
Console.WriteLine("---");

List<UserError> userErrors = new();

userErrors.Add(new NumericInputError());
userErrors.Add(new TextInputError());
userErrors.Add(new WhiteSpaceInputError());
userErrors.Add(new TabInputError());
userErrors.Add(new DeleteDataBaseError());

foreach (var userError in userErrors)
{
    Console.WriteLine(userError.UEMessage());
}

Console.WriteLine();

// 3.3
Console.WriteLine("3.3");
Console.WriteLine("---");
Console.WriteLine();

/* Frågor 
 * 
 * Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut,
 * i vilken klass bör vi lägga det?
 * 
 * Vi lägger det i Bird-klassen.
 * 
 * -----
 * 
 * Om alla djur behöver det nya attributet, vart skulle man lägga det då?
 * 
 * Då lägger vi det i Animal-klassen.
 */

//3.4
Console.WriteLine("3.4");
Console.WriteLine("---");

List<Animal> animals = new();

animals.Add(new Horse(90, 70, true, false));
animals.Add(new Dog(20, 30, true, false));
animals.Add(new Hedgehog(2, 1, true, false));
animals.Add(new Worm(0.1, 0.1, false, true));
animals.Add(new Bird(5, 20, true, true));
animals.Add(new Wolf(60, 60, true, false));
animals.Add(new Pelican(10, 10, true, true));
animals.Add(new Flamingo(8, 9, true, true));
animals.Add(new Swan(6, 5, true, true));
animals.Add(new Wolfman(75, 50, true, false));

foreach (var animal in animals)
{
    Console.WriteLine(animal.GetType().Name);
    Console.WriteLine(animal.Stats());

    if (animal is Dog)
        //    Console.WriteLine(animal.Stats());
        Console.WriteLine((animal as Dog)!.PetDog());

    if (animal is IPerson)
        (animal as IPerson)!.Talk();
    else
        animal.DoSound();

    Console.WriteLine();
}

List<Dog> dogs = new();
