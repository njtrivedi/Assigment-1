using System;



	public class Program
	{

		public static int addition(int b, int c)
		{
			return (b+c);
		}

		public static void Main()
		{
			int b, c;
			int sum;


			Console.WriteLine("Enter first number: ");
			b = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter second number: ");
			c = Convert.ToInt32(Console.ReadLine());

			sum = addition(b, c);

			Console.WriteLine("Sum is: " + sum);
		}
	}
