using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0429.Triangle.@delegate
{

	internal class Program
	{
		static void Main(string[] args)
		{
			int rows = 5;
			//靠右三角形
			Func<int,string> 靠右三角形 = i => new string('*', i).PadLeft(rows);
			DrawTriangle(rows, true, 靠右三角形);
			//靠左三角形
			Func<int, string> 靠左三角形 = i => new string('*', i).PadRight(rows - i);
			DrawTriangle(rows, true, 靠左三角形);
			//置中三角形
			Func<int, string> 置中三角形 = i => new string('*', 2*i-1).PadLeft(rows+i-1);
			DrawTriangle(rows, true, 置中三角形);
			//反靠右三角形
			Func<int, string> 反靠右三角形 = i => new string('*', i).PadLeft(rows);
			DrawTriangle(rows, false, 反靠右三角形);
			//反靠左三角形
			Func<int, string> 反靠左三角形 = i => new string('*', i).PadRight(rows - i);
			DrawTriangle(rows, false, 反靠左三角形);
			//反置中三角形
			Func<int, string> 反置中三角形 = i => new string('*', 2 * i - 1).PadLeft(rows + i - 1);
			DrawTriangle(rows, false, 反置中三角形);


		}
		/// <summary>
		/// 繪製三角形
		/// </summary>
		/// <param name="rows">三角形有幾列</param>
		/// <param name="upOrDown">正立或倒立</param>
		/// <param name="triangleType">三角形的類型</param>
		public static void DrawTriangle(int rows,bool upOrDown,Func<int, string> triangleType)
		{
			if (upOrDown)
			{
				for (int i = 1; i <= rows; i++)Console.WriteLine(triangleType(i));
			}
			if (!upOrDown)
			{
				for (int i = rows; i >= 1; i--) Console.WriteLine(triangleType(i));
			}
		}
	}

}
