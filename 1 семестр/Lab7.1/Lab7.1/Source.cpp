# include <stdio.h>
# include <conio.h>
void main()
{
	int D[5][6] = { {-1,1,-2,2,-3,3},{-4,4,-5,5,-6,6},{-7,7,-8,8,-9,9},{-10,10,-11,11,-12,12},{-13,13,-14,14,-15,15} }, c;
	for (int k = 0; k <= 4; k++)
	{
		for (int l = 0; l <= 5; l++)
		{
			for (int m = 1; m <= 5; m++)
			{
				if (D[k][m - 1] < D[k][m])
				{
					c = D[k][m - 1];
					D[k][m - 1] = D[k][m];
					D[k][m] = c;
				}
			}
		}
	}
	for (int i = 0; i <= 4; i++)
	{
		for (int j = 0; j <= 5; j++)
		{
			printf("%4d", D[i][j]);
		}
		printf("\n");
	}
	_getch();
}