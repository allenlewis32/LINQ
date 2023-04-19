using System.Diagnostics.CodeAnalysis;

namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new()
			{
				new("A", 1),
				new("B", 2),
				new("AB", 3),
				new("ABC", 3),
				new("ABC", 4),
			};
			Console.WriteLine("Distinct");
			foreach (var item in students.DistinctBy(student => student.name))
			{
				Console.WriteLine(item.name);
			}

			List<Student> students2 = new()
			{
				new("A", 1),
				new("B", 2),
				new("C", 3),
				new("D", 4),
			};
			Console.WriteLine("Except");
			foreach (var item in students.Select(x => x.name).Except(students2.Select(x => x.name)))
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("Union");
			foreach(var item in students.Union(students2))
			{
				Console.WriteLine($"Name: {item.name}, Age: {item.age}");
			}

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