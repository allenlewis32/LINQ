namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
			List<int> list2 = new() { 1, 2, 3, 4, 5, 16, 17, 18, 19, 20};

			List<List<int>> nestedList = new() { list, list2 };
			var res = nestedList.SelectMany(list => list.Where(n => n > 10));
			
			foreach(var item in res)
			{
				Console.WriteLine(item);
			}

			List<Employee> employees = new()
			{
				new(){ Id = 1, Name = "A", Dept = "Dev"},
				new(){ Id = 2, Name = "B", Dept = "Test"},
				new(){ Id = 3, Name = "C", Dept = "Dev"},
				new(){ Id = 4, Name = "D", Dept = "Test"},
			};

			var query2 = employees.Where(emp =>
			{
				return emp.Id > 2 && emp.Dept == "Test";
			});

			foreach (var item in query2)
			{
				Console.WriteLine(item.Name);
			}
		}
		class Employee
		{
			public int Id;
			public string Name;
			public string Dept;
		}
	}
}