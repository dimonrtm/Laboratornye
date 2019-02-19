# include <stdio.h>
# include <conio.h>
# include <math.h>
void main()
{
	double a = 3.0, b = 4.0, n = 16.0, y1,y2,x;
	printf("x\t             y1\t            y2\n");
	x = a;
	while(x<=b)
	{
		y1 = exp(2.0)*atan(x) - pow((x + 1), 1.0 / 5.0);
		y2 = exp(a*x*x);
		printf("%f\t%f\t %e\n", x, y1, y2);
		x = x + (1 / n);
	}

	_getch();
}