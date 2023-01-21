using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_6
{
	internal class Value
	{
		public static double[] GetDoubleArray(string value)
		{
		checkString:
			Console.WriteLine(value);
			string input = Console.ReadLine();
			string[] array = input.Split(',');
			if (array[array.Length-1] == "")
			{
				Console.WriteLine("Ввели последним знаком запятую.");
				goto checkString;
			}
			double[] doubleArray = new double[array.Length];
			for(int i = 0; i < array.Length;i++)
			{
				try
				{
					doubleArray[i] = Convert.ToDouble(array[i]);
				}
				catch 
				{
					Console.WriteLine(array[i] + " - не цифра или не верный ввод чисел.");
					goto checkString;
				}				
			}
			return doubleArray;
		}
	}
}
