# include <stdio.h>
# include <conio.h>
# include <math.h>
void main()
{
	double a=3.0,  b = 4.0, n = 16.0, y1[17], y2[17], xi[17];
	int i = 0;
	printf("x\t             y1\t             y2\n");
	for (double x = a; x <= b&&i<=16; x = x + (1 / n))
	{
		xi[i] = x;
		y1[i] = exp(2.0)*atan(x) - pow((x + 1), (1.0 / 5.0));
		y2[i] = exp(a*x*x);
		i++;
	}
	for (int j = 0; j <= 16; j++)
	{
		printf("%f\t%f\t %e\n", xi[j], y1[j], y2[j]);
	}
	_getch();
}