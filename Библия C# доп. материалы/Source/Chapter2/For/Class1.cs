using System;

class EasyCSharp
{
	public static void Main()
	{
		int sum=1, max=5;
		for (int i = 2; i<=max;)
		{
			sum *=i;
			i++;
		}
		Console.WriteLine(sum);
	}	
}
