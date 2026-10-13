using System.Security.Authentication;

namespace L102Operators
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var test = 5;
			Console.WriteLine(++test);
			var test2 = 5;
			Console.WriteLine(test2++);
			// Thu nghiem voi char
			char test3 = 'c';
			var result = test - 10;
			Console.WriteLine($"result = {result}");
			//BT1
			//Exercise 1
			int a = 20;
			int b = 6;
			var result1 = a + b;
			var result2 = a - b;
			var result3 = a * b;
			var result4 = a / b;
			Console.WriteLine($"result1 = {result1}, result2 = {result2}, result3 = {result3}, result4 = {result4}");
			//Exercise 2
			Console.WriteLine(++a);
			Console.WriteLine(--a);
			//Exercise 3
			Boolean result5 = a == b;
			Boolean result6 = a != b;
			Boolean result7 = a < b;
			Boolean result8 = a > b;
			Boolean result9 = a <= b;
			Boolean result10 = a >= b;
			Console.WriteLine($"result5 = {result5}, result6 = {result6}, result7 = {result7}, result8 = {result8}, result9 = {result9}, result10 = {result10}");
			//Exercise 4	
			bool logicAnd = (a > 10) && (b < 10);
			bool logicOr = (a > 15) || (b > 7);
			bool logicNot = !(a > 25);
			Console.WriteLine($"logicAnd = {logicAnd}, logicOr = {logicOr}, logicNot = {logicNot}");
			int x = a;
			Console.WriteLine($"truoc += : x = {x}");
			x += 5;
			Console.WriteLine($"sau += : x = {x}");
			Console.WriteLine($"truoc -= : x = {x}");
			x -= 10;
			Console.WriteLine($"sau -= : x = {x}");
			Console.WriteLine($"truoc *= : x = {x}");
			x *= 2;
			Console.WriteLine($"sau *= : x = {x}");
			Console.WriteLine($"truoc /= : x = {x}");
			x /= 4;
			Console.WriteLine($"sau /= : x = {x}");
			Console.WriteLine($"truoc %= : x = {x}");
			x %= 5;
			Console.WriteLine($"sau %= : x = {x}");
			x %= 10;
			Console.WriteLine($"sau %= : x = {x}");
			//Nullabe Type 
			int? score = null;
			string input = null;
			string displayName = input ?? "chua dat ten";
			Console.WriteLine($"displayName = {displayName}");
			string message = null;
			message ??= "Xin chào!"; // Vì message là null nên được gán "Xin chào!"
			message ??= "Tạm biệt!"; // Bị bỏ qua vì message đã có giá trị
			Console.WriteLine($"message = {message}");
			string note = null;
			if (note is null)
			{
				Console.WriteLine("note is null");
			}
			if (note is not null)
			{
				Console.WriteLine("note is not null");
			}
			Console.WriteLine(Math.Max(a, b));
			Console.WriteLine(Math.Min(a, b));
			Console.WriteLine(Math.Abs(-15));
			Console.WriteLine(Math.Pow(2, 3));
			Console.WriteLine(Math.Round(3.6));



		}
	}
}
