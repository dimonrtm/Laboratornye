# include <stdio.h>
# include <conio.h>

 double summ( double b[10])
{
	 double summ = 0, y = 1;
	for (int j = 9; j >= 0; j--)
	{
		summ = summ + b[j];
		y = y*summ;
	}
	return y;
}

void main()
{
	 double a[10] = { 5.0,6.0,1.0,2.0,3.0,4.0,5.0,6.0,9.0,7.0 };
	 double y;
	y = summ(a);
	printf("y raven %.0f\n", y);
	_getch();
}