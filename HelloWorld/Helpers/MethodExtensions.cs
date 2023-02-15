
using System.Text;

namespace HelloWorld.Helpers
{
    public static class MethodExtensions
    {
        public static void CustomWriteLine(this string text, int lineJumps = 1)
        {
            //Quando há concatenação frequente de string, a string anterior
            //à concatenação é perdida, é instanciada uma nova string na memória.
            //O StringBuilder evita a realocação de string na memória, 
            //e cria a string por completo quando é utilizado o método .ToString().
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= lineJumps; i++)
            {
                sb.Append("\n");
            }
            Console.WriteLine($"{text}{sb}");


        }


    }

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
