
using System.Text;

namespace HelloWorld.Helpers
{    
    public static class ConsoleExtensions
    {

        public static string ReadLine(string message = null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            
            return Console.ReadLine();
        }

    }
}
