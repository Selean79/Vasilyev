using System;

class EasyCSharp
{
	public static void Main()
	{
		int sum=1, max=5;
		int i = 2;
		do 
		{
			sum *=i;
			i++;
		}while (i<=max);
		Console.WriteLine(sum);
	}	
}
