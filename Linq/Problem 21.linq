<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Drawing.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.XML.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Xaml.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Xml.Linq.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\WindowsBase.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationCore.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationFramework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\System.Windows.Presentation.dll</Reference>
  <Reference>C:\Projects\DynamicLinq.dll</Reference>
  <Namespace>System.Drawing</Namespace>
  <Namespace>System.Numerics</Namespace>
  <Namespace>System.Linq</Namespace>
  <Namespace>System.Linq.Expressions</Namespace>
  <Namespace>System.Linq.Dynamic</Namespace>
  <Namespace>System.Reflection</Namespace>
  <Namespace>System.Reflection.Emit</Namespace>
  <Namespace>System.Xml</Namespace>
  <Namespace>System.Xml.Linq</Namespace>
  <Namespace>System.Windows.Controls</Namespace>
</Query>

/*

Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

For example, 

the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; 

therefore d(220) = 284. 

The proper divisors of 284 are 1, 2, 4, 71 and 142; 

so d(284) = 220.

Evaluate the sum of all the amicable numbers under 10000.

*/

void Main()
{
	Dictionary<int,int> divisors = new Dictionary<int,int>();
	
	for( int i = 1; i < 10000; i++ )
	{
		divisors.Add( i, GetSumOfProperDivisors( i ) );
	}
	
	List<Tuple<int,int>> amicableNumbers = new List<Tuple<int,int>>();
	
	foreach( int a in divisors.Keys )
	{
		int b = divisors[ a ];
		
		if( divisors.ContainsKey( b ) && divisors[ b ] == a && a != b)
		{
			amicableNumbers.Add( new Tuple<int,int>( a, b ) );
		}
	}
	
	amicableNumbers.Sum( an => an.Item1 ).Dump();
}

int GetSumOfProperDivisors( int n )
{
	int sum = 0;
	
	for( int i = 1; i < ( n / 2 ) + 1; i++)
	{
		if( n % i == 0 )
			sum += i;
	}
	
	return sum;
}