using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Lab4
{
	internal class Program
	{
		public class userDataLab4
		{
			public string name;
			public int level;


			public userDataLab4(string _name, int lv)
			{
				name = _name;
				level = lv;
			}
		}
		static void Main()
		{
			List<userDataLab4> list = new List<userDataLab4>();
			list.Add(new userDataLab4("GTA 5", 10));
			list.Add(new userDataLab4("Genshin impact", 15));
			list.Add(new userDataLab4("Gunny", 9));
			list.Add(new userDataLab4("Lien Minh Huyen Thoai", 111));
			var selectedData = list.Select(u => new {u.name,u.level});
			foreach (var item in selectedData)
			{
				Console.WriteLine("Name: " + item.name + " |level: " + item.level);
			}
		}

	}
}
