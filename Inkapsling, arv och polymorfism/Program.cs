namespace Inkapsling__arv_och_polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            List<Animal> animals = new();

            animals.Add(new Horse(500, 100, true, false));
            animals.Add(new Dog(20, 30, true, false));
            animals.Add(new Hedgehog(2, 1, true, false));
            animals.Add(new Worm(0.1, 0.1, false, true));
            animals.Add(new Bird(5, 20, true, true));
            animals.Add(new Wolf(100, 30, true, false));

            foreach (var animal in animals)
            {
                animal.DoSound();
            }
        }
    }
}
