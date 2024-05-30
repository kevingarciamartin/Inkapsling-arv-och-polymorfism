namespace Inkapsling__arv_och_polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3.1
            try
            {
                PersonHandler personHandler = new();

                Person person1 = personHandler.CreatePerson(28, "Kevin", "Garcia Martin", 1.94, 95);
                //Person person2 = personHandler.CreatePerson(0, "Baby", "Blue", 0.45, 0.41);
                //Person person3 = personHandler.CreatePerson(77, "B", "Larsson", 1.63, 78);
                //Person person4 = personHandler.CreatePerson(52, "Anja", "Peeeeeeeeeeeeeeeeeeeeeeeeeeersson", 1.72, 80);
            }
            catch (ArgumentException aex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(aex.Message);
                //Console.WriteLine(aex.StackTrace);
            }
            finally
            {
                Console.ResetColor();
            }

            // 3.2
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
        }
    }
}
