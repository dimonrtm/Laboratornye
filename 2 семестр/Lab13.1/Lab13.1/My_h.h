# include <stdio.h>
# include <conio.h>

extern int b;
int power(int, int);

int power(int a, int b)
{
	int result = 1;
	for (int i = 1; i <= b; i++)
	{
		result *= a;
	}
	return result;
}
