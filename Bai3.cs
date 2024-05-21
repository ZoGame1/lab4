using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4B3
{
	internal class Program
	{
		public class studentLab4
		{
			public string ID;
			public string Name;
			public int age;

			public studentLab4(string _ID, string _name, int _age)
			{
				ID = _ID;
				Name = _name;
				age = _age;
			}
			static void Main()
			{
				Console.OutputEncoding = Encoding.UTF8;
				List<studentLab4> List = new List<studentLab4>();
				List.Add(new studentLab4("1", "Phan Quoc", 15));
				List.Add(new studentLab4("2", "huynh Le ", 17));
				List.Add(new studentLab4("3", "le ha", 20));
				List.Add(new studentLab4("4", "Van dai", 16));
				List.Add(new studentLab4("5", "huu Nghia",18));

				var query = from studentLab in List
							where studentLab.age > 12 && studentLab.age < 20
							select studentLab; 
				Console.WriteLine("Xuất ra màn hình các student có Age > 12 và Age <20 bằng cách dùng LINQ Query Syntax");
				foreach (var studentLab in List)
				{
					Console.WriteLine($"Name:{studentLab.Name}, age:{studentLab.age}");
				}
				var method = List.Where(studentLab => studentLab.age > 12 && studentLab.age < 20);

				Console.WriteLine("\nCác sinh viên có tuổi từ 12 đến 20 (LINQ Method Syntax):");
				foreach (var studentLab in method)
				{
					Console.WriteLine($"Name: {studentLab.Name}, Age: {studentLab.age}");
				}

			}
		}
	}
}
