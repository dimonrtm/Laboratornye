# include <stdio.h>
# include <conio.h>
# include <math.h>
double func(double x, double a, double b, double c)
{
	double z;
	z = fabs(log(b - sqrt(fabs(x))))*(x - c / (a + pow(x, 2.0) / 4));
	return z;
}
void main()
{
	double x1 = 1.0, x2 = 2.0, a = 2.0, b = 3.0, c = 1.0, w1,w2;
	w1 = func(x1, a, b, c);
	w2 = func(x2, a, b, c);
	printf("f(x1) ravna %f, f(x2) ravna %f\n", w1, w2);
	_getch();
}