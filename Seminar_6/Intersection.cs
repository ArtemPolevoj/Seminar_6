using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_6
{
	internal class Intersection
	{
		public static void GetIntersection()
		{
			string inputValue = "Введите значения b1, k1, b2 и k2 через запятую.";
			double[] data = Value.GetDoubleArray(inputValue);
			if(data.Length != 4) 
			{
				Console.WriteLine("Введено не верное количество значений.");
				data = Value.GetDoubleArray(inputValue);
			}
			double b1 = data[0];
			double k1 = data[1];
			double b2 = data[2];
			double k2 = data[3];
			
			if (k1 == k2 & b1 != b2) Console.WriteLine("Прямые паралельны.");

			else if (k1 == k2 & b1 == b2) Console.WriteLine("Прямые совпадают.");

			else
			{
				double x = (b2 - b1) / (k1 - k2);
				double y = k1 * x + b1;

				Console.WriteLine($"Прямые пересекаются в точке: ({x};{y}).");
			}

		}
	}
}
