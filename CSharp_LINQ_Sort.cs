using System;
using System.Linq;
using System.Collections.Generic;

namespace Sort
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var sort = new SortClass();

			sort.GetSort();
		}
	}

	class SortClass
	{
		public void GetSort()
		{
			var source = new[] {
				new {Name = "Taro", Age = 20},
				new {Name = "Hanako", Age = 17},
				new {Name = "Kenji", Age = 32},
				new {Name = "Kanako", Age = 23}, 
				new {Name = "Goro", Age = 17},    
			};

			// OrderBy()
			// 昇順にソート
			var friend1 = source.OrderBy(n => n.Age);
			foreach (var name1 in friend1)
				Console.WriteLine(name1);
			Console.WriteLine();

			// OrderByDescending()
			// 降順にソート
			var friend2 = source.OrderByDescending(e => e.Age);
			foreach (var name2 in friend2)
				Console.WriteLine(name2);
			Console.WriteLine();

			// ThenBy()
			// キーが等しい要素を優先して、昇順にソート
			var friend3 = source.OrderBy(e => e.Age).ThenBy(n => n.Name.Length);
			foreach (var name3 in friend3)
				Console.WriteLine(name3);
			Console.WriteLine();

			// ThenByDescending()
			// キーが等しい要素を優先して、降順にソート
			var friend4 = source.OrderBy(e => e.Age).ThenByDescending(n => n.Name.Length);
			foreach (var name4 in friend4)
				Console.WriteLine(name4);
			Console.WriteLine();

			// Reverse()
			// 逆順にソート
			var friend5 = source.Reverse();
			foreach (var name5 in friend5)
				Console.WriteLine(name5);
			Console.WriteLine();
		}
	}
}

