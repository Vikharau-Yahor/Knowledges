using System;

namespace Some
{

	public enum Test
	{
		One,
		Two,
		Three
	}
	
	public class Person
	{
		public string Name  { get; set; }
		public int Age { get; set; }
		public static int SomeField = 5;
	}

	class Program
    	{
		static void Main()
        	{
			var newPerson = new Person();
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}