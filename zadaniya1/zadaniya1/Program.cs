using System;

namespace zadaniya1
{
	class Program
	{

		static void Main(string[] args)
		{
			Changation<double> changations;
			Console.WriteLine("X: ");
			double.TryParse(Console.ReadLine(), out double x);
			Console.WriteLine("Y: ");
			double.TryParse(Console.ReadLine(), out double y);
			Console.WriteLine("+,-,*,/");
			char chang = Convert.ToChar(Console.ReadLine());

			switch (chang)
			{
				case '+':
					changations = Pilus;
					Console.WriteLine($"Result: {changations?.Invoke(x, y)}");
					break;
				case '-':
					changations = Minus;
					Console.WriteLine($"Result: {changations?.Invoke(x, y)}");
					break;
				case '*':
					changations = Umnog;
					Console.WriteLine($"Result: {changations?.Invoke(x, y)}");
					break;
				case '/':
					changations = Delen;
					Console.WriteLine($"Result: {changations?.Invoke(x, y)}");
					break;
				default:
					Console.WriteLine("Ошибка, доступные символы + - * /");
					break;
			}
		}
		delegate T Changation<T>(T x, T y);

		private static T Pilus<T>(T x, T y)
		{
			return (dynamic)x + (dynamic)y;
		}
		private static T Minus<T>(T x, T y)
		{
			return (dynamic)x - (dynamic)y;
		}
		private static T Umnog<T>(T x, T y)
		{
			return (dynamic)x * (dynamic)y;
		}
		private static T Delen<T>(T x, T y)
		{
			if ((dynamic)y == 0) throw new Exception("Ошибка деления на ноль");
			else return (dynamic)x / (dynamic)y;
		}
	}
}