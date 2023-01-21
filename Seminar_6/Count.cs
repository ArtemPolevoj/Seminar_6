using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_6
{
	internal class Count
	{
		public static void GetCountPositiveNumber(double[] array)
		{
			int count = 0;
			foreach (double value in array)
			{
				if(value > 0) count++;
			}
			Console.WriteLine($"Количество введенных положительных чисел - {count}");
		}
	}
}
