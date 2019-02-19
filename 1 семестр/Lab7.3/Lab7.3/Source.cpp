# include <stdio.h>
# include <conio.h>
# include <math.h>
void main()
{
	double a = 3.0, b = 4.0, n = 16.0,func[3][17];
	int i = 0;
	printf("x\t             y1\t             y2\n");
	for (double x = a; x <= b&&i <= 16; x = x + (1 / n))
	{
		func[0][i] = x;
		func[1][i] = exp(2.0)*atan(x) - pow((x + 1), (1.0 / 5.0));
		func[2][i] = exp(a*x*x);
		i++;
	}
	for (int j = 0; j <= 16; j++)
	{
		printf("%f\t%f\t %e\n", func[0][j], func[1][j], func[2][j]);
	}
	printf("\n");
	for (int i = 0; i <= 2; i++)
	{
		for (int j = 0; j <= 16; j++)
		{
			printf("%e ", func[i][j]);
		}
		printf("\n");
	}
	_getch();
}