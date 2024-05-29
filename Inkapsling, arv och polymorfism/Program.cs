namespace Inkapsling__arv_och_polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new("Kevin", "Garcia Martin");
                person.setAge(28);
            }
            catch (ArgumentException aex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(aex.Message);
            }
            finally
            {
                Console.ResetColor();
            }
        }
    }
}
