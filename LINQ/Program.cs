using System.Diagnostics.CodeAnalysis;

namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new() { 5, 1, 4, 2, 3, 10, 6, 9, 7, 8, 0 };
			list.Take(5).ToList().ForEach(x => Console.WriteLine(x));
			list.TakeWhile(x => x < 10).ToList().ForEach(x => Console.WriteLine(x));
		}
		class Student
		{
			public string name;
			public int age;
			public Student(string name, int age)
			{
				this.name = name;
				this.age = age;
			}
		}
	}
}