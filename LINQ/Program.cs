using System.Diagnostics.CodeAnalysis;

namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new() { 5, 1, 4, 2, 3 };
			numbers.Reverse();
			var res = numbers.FindAll(x => x > 2);
			foreach (var item in res) Console.WriteLine(item);

			List<Student> students = new() { new("A", 14), new("B", 23), new("C", 41), new("D", 32) };

			Console.WriteLine(students.Contains(new("A", 14), new Comp()));
		}
		class Comp : EqualityComparer<Student>
		{
			public override bool Equals(Student? x, Student? y)
			{
				if (x == null || y == null) return false;
				return x.name == y.name && x.age == y.age;
			}

			public override int GetHashCode([DisallowNull] Student obj)
			{
				throw new NotImplementedException();
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