namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<object> list = new() { 1, "one", 2, "two", 3, "three", 4, "four" };
			var query = list.OfType<int>().ToList();
			var query2 = (from a in list where a is string orderby a select a);
			foreach (var item in query2)
			{
				Console.WriteLine(item);
			}
		}
	}
}