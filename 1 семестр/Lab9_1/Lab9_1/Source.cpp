# include <stdio.h>
# include <conio.h>

void sort(int d[5][6], int a[5][6], int*e, int*b)
{
	int c;
	for (int k = 0; k <= 4; k++)
	{
		for (int l = 0; l <= 5; l++)
		{
			for (int m = 1; m <= 5; m++)
			{
				if (d[k][m - 1] < d[k][m])
				{
					c = d[k][m - 1];
					d[k][m - 1] = d[k][m];
					d[k][m] = c;
				}
				if (a[k][m - 1] < a[k][m])
				{
					c = a[k][m - 1];
					a[k][m - 1] = a[k][m];
					a[k][m] = c;
				}
			}
		}
	}
	*e = d[0][0];
	*b = a[0][0];
}

void main()
{
	int D[5][6] = { { -1,1,-2,2,-3,3 },{ -4,4,-5,5,-6,6 },{ -7,7,-8,8,-9,9 },{ -10,10,-11,11,-12,12 },{ -13,13,-14,14,-15,15 } };
	int A[5][6] = { {1,2,3,4,5,6},{7,8,9,10,11,12},{13,14,15,16,17,18},{19,20,21,22,23,24},{25,26,27,28,29,30} };
	sort(D, A, &D[0][0], &A[0][0]);
	for (int i = 0; i <= 4; i++)
	{
		for (int j = 0; j <= 5; j++)
		{
			printf("%4d", D[i][j]);
		}
		printf("\n");
	}
	for (int i = 0; i <= 4; i++)
	{
		for (int j = 0; j <= 5; j++)
		{
			printf("%4d", A[i][j]);
		}
		printf("\n");
	}
	_getch();
}