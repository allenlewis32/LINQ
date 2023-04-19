namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> list = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
			var query = from name in list select name;

			List<string> list2 = new();
			for (int i = 0; i < 3; i++)
			{
				list2.Add(list[i]);
			}

			List<Student> students = new()
			{
				new(){ Id = 1, Name = "Allen", Email = "allenlewis32@gmail.com"},
				new(){ Id = 2, Name = "Patricia", Email = "rheonapatricia@gmail.com"},
				new(){ Id = 3, Name = "Rex", Email = "hermanrexj@gmail.com"},
				new(){ Id = 4, Name = "Janet", Email = "janetrex72@gmail.com"},
			};

			var query2 = from student in students where student.Id > 2 select student;

			foreach (var item in query2)
			{
				Console.WriteLine(item.Name);
			}
		}
		class Student
		{
			public int Id;
			public string Name;
			public string Email;
		}
	}
}