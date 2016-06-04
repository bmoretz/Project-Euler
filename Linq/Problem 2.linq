<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Drawing.dll</Reference>
  <Namespace>System.Drawing</Namespace>
</Query>

/*

Each new term in the Fibonacci sequence is generated by adding the previous two terms. 

By starting with 1 and 2, the first 10 terms will be:

1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

Q: By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

A: 4613732

*/

int a = 0, b = 1;

int sum = 0;

for( ;; )
{
	int c = a + b;
	
	if( c >= 4000000 )
		break;
	
	if( c % 2 == 0 )
		sum += c;
		
	a = b; b = c;
}

sum.Dump();