using System.Diagnostics.Contracts;

namespace L103ConditionsFlowLoop
{
	internal class Program
	{
		static void Main(string[] args)
		{

			/*	int age = 18;
				string status = age >= 18 ? "nguoi lon" : "tre con";
				Console.WriteLine(status);
				//example switch case 
				int day = 3;
				switch(day)
				{
					case 1:
						Console.WriteLine("thu 2");
						break;
					case 2:
						Console.WriteLine("thu 3");
						break;
					case 3:
						Console.WriteLine("thu 4");
						break;
			*/
			//excercise 1 :
			int number = Random.Shared.Next(1, 101);
			Console.WriteLine($"so vua tao ra : {number} ");
			if (number > 50)
			{
				Console.WriteLine("The number is greater than 50 ");
			}
			else
			{
				Console.WriteLine("the number is less than or equal to 50");
			}
			//exercise 2 :
			int number2 = 83;
			if (number2 % 2 == 0)
			{
				Console.WriteLine("so nay la so chan");

			}
			else
			{
				Console.WriteLine("so nay la so le");
			}
			//exrecise 3 :
			int grade = 90;
			if (grade >= 90)
			{
				Console.WriteLine("cong viec tuyet voi");

			}
			if (grade > 80 && grade < 90)
			{
				Console.WriteLine("cong viec tot");
			}
			if (grade > 70 && grade < 80)
			{
				Console.WriteLine("co co gang");
			}
			if (grade < 70)
			{
				Console.WriteLine("ban can phai co gang hon");
			}
			//exercise 4 :
			string jobTitle = "manager";
			switch (jobTitle)
			{
				case ("manager"):
					{
						Console.WriteLine("ban la nguoi quan ly");
					}
					break;
				case ("employee"):
					{
						Console.WriteLine("ban la nhan vien");
					}
					break;
				case ("intern"):
					{
						Console.WriteLine("ban la nguoi hoc");
					}
					break;

			}
			//exercise 11:
			int number3 = -10;
			if (number3 > 0)
			{
				Console.WriteLine("so duong");
			}
			if (number3 < 0)
			{
				Console.WriteLine("so am");
			}
			else
			{
				Console.WriteLine("so khong");
			}
			//exercise 12:
			string dayOfweek = "Monday";
			switch (dayOfweek)
			{
				case ("Monday"):
					{
						Console.WriteLine("tuan moi bat dau");
					}
					break;
				case ("Friday"):
					{
						Console.WriteLine("cuoi tuan roi");
					}
					break;
				default:
					{
						Console.WriteLine("ngay binh thuong");
					}
					break;

			}
			//exercise 13:
			int number4 = 30;
			if (number4 % 5 == 0 && number4 % 3 == 0)
			{
				Console.WriteLine("chia het cho ca 3 ava 5");
			}
			else if (number4 % 5 == 0)
			{
				Console.WriteLine("chia het cho 5");
			}
			else if (number4 % 3 == 0)
			{
				Console.WriteLine("chia het cho 3");
			}
			else
			{
				Console.WriteLine("khong chia het cho ca 3 va 5");
			}
			//exercise 5:
			while (true)
			{
				int r5 = Random.Shared.Next(1, 11);
				Console.WriteLine($"so vua tao ra : {r5}");
				if (r5 == 7)
				{
					Console.WriteLine("da gap so 7 ngung vong lap");
				}
				break;
			}
			//exercise 6:
			int userInput;
			bool isvalid;
			do {
				Console.WriteLine("nhap vao mot so tu 1 den 100");
				string input = Console.ReadLine();
				isvalid = int.TryParse(input, out userInput) && userInput >= 1 && userInput <= 100;
				if (!isvalid)
				{
					Console.WriteLine("so khong hop le vui long nhap lai");
				}
			}while (!isvalid);
			Console.WriteLine($"ban da nhap so thanh cong: {userInput} ");
			//exercise 7:
			int count = 1;
			while (count <= 10)
			{
				Console.WriteLine($"dem so : {count}");
				count++;
			}
			//exercise 8:
			int sum = 0;
			for(int i =1; i<=10;i++)
			{
				int r8 = Random.Shared.Next(1, 101);
				Console.WriteLine($"so thu {i}: {r8}");
				sum += r8;
			}
			Console.WriteLine($"tong cua 10 so vua tao la :{sum}");
			//exercise 9:
			for(int i=1; i<=10;i++)
			{
				Console.WriteLine($"10 so chan dau tien la:{i * 2} ");
			}
			//exercise 10:
			int r10;
			do
			{
				r10 = Random.Shared.Next(1, 101);
				Console.WriteLine($"so sinh ra la : {r10}");
			} while (r10 <= 50);
			Console.WriteLine($"da tim thay so lon hon 50 : {r10}");
			//exercise 14:
			int length = 5;
			int width = 10;
			int area = length * width;
			Console.WriteLine($"dien tich cua hinh chu nhat la : {area} ");
			//exercise 15:
			int f0 = 0 , f1 = 1;
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine($"so thu {i} trong day fibonacci la : {f0}");
				int next = f0 + f1;
				f0 = f1;
				f1 = next;
			}
			Console.WriteLine();
			//exercise 16:
			int n = 45;
			if (n > 0 && n <= 50)
			{
				Console.WriteLine("gia tri nam trong khoang 0-50");
			}
			else if (n > 50 && n <= 100)
			{
				Console.WriteLine("gia tri nam trong khoang 51-100");
			}
			else
			{
				Console.WriteLine("gia tri nam ngoai khoang 0-100");
			}
			//exercise 17:
			int r17;
			do
			{
				r17 = Random.Shared.Next(1, 101);
				Console.WriteLine($"so vua tao ra : {r17}");
			} while (r17 != 50);
			Console.WriteLine("da tim thay so 55 ngung chuong trinh");
		}
	}
}
