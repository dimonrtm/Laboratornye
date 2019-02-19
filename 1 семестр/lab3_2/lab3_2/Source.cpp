# include <stdio.h>
# include <conio.h>
# include <math.h>
void main()
{
	double a = 3.0, b = 4.0, n = 16.0,y1,y2;
	printf("x\t             y1\t             y2\n");
	for (double x = a;x <= b;x = x +( 1 / n))
	{
		y1 = exp(2.0)*atan(x) - pow((x + 1), 1.0 / 5.0);
		y2 = exp(a*x*x);
		printf("%f\t%f\t %e\n", x, y1, y2);
	}

	_getch();
}