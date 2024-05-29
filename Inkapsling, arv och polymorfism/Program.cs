namespace Inkapsling__arv_och_polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PersonHandler personHandler = new();
                Person person = personHandler.CreatePerson(28, "Kevin", "Garcia Martin", 1.94, 95);
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
        }
    }
}
