namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new()
			{
				new(1, "A", 14),
				new(2, "B", 15),
				new(3, "C", 41),
				new(4, "D", 23),
				new(5, "E", 32),
				new(6, "F", 51),
				new(7, "G", 57),
				new(8, "H", 75),
				new(9, "I", 1),
			};
			//Console.WriteLine("Skip");
			//students.Skip(5).Print();
			//Console.WriteLine("SkipWhile");
			//students.SkipWhile(x => x.Age < 18).Print();

			List<Marks> marks = new()
			{
				new(1, 90, 91, 92),
				new(2, 93, 94, 95),
				new(3, 96, 97, 98),
				new(4, 99, 90, 91),
				new(5, 92, 93, 94),
			};
			var query = from student in students join mark in marks on student.Id equals mark.Id select new { s = student.Name, m1 = mark.mark1, m2 = mark.mark2, m3 = mark.mark3 };
			//query.Print(item => $"Name: {item.s}\nMark 1: {item.m1}\nMark 2: {item.m2}\nMark 3: {item.m3}");

			var query2 = students.Join(marks, s => s.Id, m => m.Id,
				(s, m) => new { s = s.Name, m1 = m.mark1, m2 = m.mark2, m3 = m.mark3 });
			query.Print(item => $"Name: {item.s}\nMark 1: {item.m1}\nMark 2: {item.m2}\nMark 3: {item.m3}");
		}
	}
	class Marks
	{
		public int Id, mark1, mark2, mark3;
		public Marks(int Id, int mark1, int mark2, int mark3)
		{
			this.Id = Id;
			this.mark1 = mark1;
			this.mark2 = mark2;
			this.mark3 = mark3;
		}
	}
	class Student
	{
		public int Id;
		public string Name;
		public int Age;
		public Student(int Id, string name, int age)
		{
			this.Id = Id;
			this.Name = name;
			this.Age = age;
		}
		public override string ToString()
		{
			return $"Id = {Id}, Name = {Name}, age = {Age}";
		}
	}
	static class LE
	{
		public static void Print<T>(this IEnumerable<T> enumerable)
		{
			foreach (T item in enumerable)
			{
				Console.WriteLine(item);
			}
		}
		public static void Print<T, T2>(this IEnumerable<T> enumerable, Func<T, T2> func)
		{
			foreach (T item in enumerable)
			{
				Console.WriteLine(func(item));
			}
		}
	}
}