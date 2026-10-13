namespace L102Variables
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//BT1 
			bool A = true;
			char B = 'c';
			decimal C = 2.5m;
			double D = 2.5;
			float E = 2.5F;
			int F = 15;
			String G = "GG";
			Console.WriteLine($" in ra ket qua cua cac bien: A = {A}, B = {B}, C = {C}, D = {D}, E = {E}, F = {F}, G = {G}");
			A = false;
			B = 'd';
			C = 3.5m;
			D = 3.5;
			E = 4.5F;
			F = 20;
			G = "Easy";
			Console.WriteLine($" in ra ket qua cua cac bien: A = {A}, B = {B}, C = {C}, D = {D}, E = {E}, F = {F}, G = {G}");
			//BT2
			char L = 'c';
			int num1 = (int)L;
			int num2 = 100;
			char K = (char)num2;
			Console.WriteLine($" in ra ket qua cua {num1} , {K} ");
			// viet chuong trinh cho phep nhan ten va tuoi tu ban phim //
			string name;
			int age;
			Console.Write("nhap ten cua ban :");
			name = Console.ReadLine();
			Console.Write("nhap tuoi cua ban :");
			age = int.Parse(Console.ReadLine());
			Console.WriteLine($"ten cua ban la : {name} va tuoi cua ban la : {age}");
			//BT4
			var a = 10;
			var b = 20.5;
			var c = "goodbye";
			var d = true;
			var e = 'e';
			var f = 3.15m;
			var g = 2.5F;
			var aa = 100;
			var bb = "Hello";
			var cc = 3.14;	
			Console.WriteLine($" in ra ket qua cua cac bien: a = {a}, b = {b}, c = {c}, d = {d}, e = {e}, f = {f}, g = {g} ,aa = {aa}, bb = {bb}, cc = {cc}");
			//BT5
			const int i = 100;
			const string j = "Hello";
			const double k = 3.14;
			const bool l = true;
			const char m = 'm';
			const decimal n = 2.5m;
			const float o = 2.5F;
			const long p = 1000000L;
			const short q = 100;
			const byte r = 255;
			Console.WriteLine($" in ra ket qua cua cac bien: i = {i}, j = {j}, k = {k}, l = {l}, m = {m}, n = {n}, o = {o}, p = {p}, q = {q}, r = {r}");

		}
	}
}
