using System;

public static class Globals
{
	internal static void Main()
	{
		Console.Write("Cati ani bisecti sunt in intervalul dintre ani:");
		Console.Write("\n");
		int y1;
		int y2;
		int bis = 0;

		Console.Write("Y1 = ");
		y1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Y2 = ");
		y2 = Convert.ToInt32(Console.ReadLine());
		y1++;
		while (y1 < y2)
		{

			if (y1 % 4 == 0)
			{
				bis++;
			}
			if (y1 % 100 == 0)
			{
				bis--;
			}
			if (y1 % 400 == 0)
			{
				bis++;
			}

			y1++;

		}
		Console.Write("In acest interval sunt - ");
		Console.Write(bis);
		Console.Write("  ani bisecti");



	}
}


