# include <stdio.h>
# include <conio.h>
void main()
{
	int mass[9] = { 1,2,3,4,5,6,7,8,9 }, TablPif[10][10];
	TablPif[0][0] = 0;
	for (int i = 0; i <= 8; i++)
	{
		TablPif[0][i + 1] = mass[i];
		TablPif[i + 1][0] = mass[i];
	}
	for (int i = 1; i <= 9; i++)
	{
		for (int j = 0; j <= 8; j++)
		{
			TablPif[i][j + 1] = mass[j] * i;
		}
	}
	for (int k = 0; k <= 9; k++)
	{
		for (int n = 0; n <= 9; n++)
		{
			printf("%3d", TablPif[k][n]);
		}
		printf("\n");
	}
	_getch();
}