# include <stdio.h>
# include <conio.h>
void main()
{
	double a[10]= { 5.0,6.0,1.0,2.0,3.0,4.0,5.0,6.0,9.0,7.0 },summ=0,y=1;
	for (int j = 9; j>=0; j--)
	{
		summ = summ + a[j];
		y = y*summ;
	}
	printf("y raven %.0f\n", y);
	_getch();
}