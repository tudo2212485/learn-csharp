using System.Text;

namespace L101HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;

            Console.WriteLine("Hello Mom!");
            string ten = "Tu";
            int tuoi = 22;
            Console.WriteLine($"My name's {ten}.");
            Console.WriteLine($"I'm {tuoi} years old.");
            Console.WriteLine("\t Hello Mom!");
            Console.WriteLine("\n Hello Mom!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("toi dang la thuc tap vien");
            Console.ResetColor();


		}
    }
}
