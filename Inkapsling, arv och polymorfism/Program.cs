namespace Inkapsling__arv_och_polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new("Kevin", "Garcia Martin");
                PersonHandler age = new();
                age.SetAge(person, 28);
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
