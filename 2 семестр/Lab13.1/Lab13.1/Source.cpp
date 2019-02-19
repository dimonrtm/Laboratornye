# include <stdio.h>
# include <conio.h>
# include "My_h.h"

int b;
void main()
{
	int a[5][5];
	for (int i = 1; i <= 5; i++)
	{
		for (int j = 0; j <= 4; j++)
		{
			a[i - 1][j] = power(j + 1, i);
		}
	}
	for (int m = 0; m <= 4; m++)
	{
		for (int n = 0; n <= 4; n++)
		{
			printf("%4d ", a[m][n]);
		}
		printf("\n");
	}
	_getch();
}