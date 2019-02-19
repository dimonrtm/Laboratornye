# include <stdio.h>
# include <conio.h>
# include <math.h>
#include<iostream>
void main()
{
	double L, x;
	printf("Vvedite chislo\n");
	scanf_s("%f",&L);
	x = L;
	int i = 0;
	do
	{
		x = tan(x);
		std::cout << i << ": " << x << "\n";
		i++;
	} while (x > 0);
	printf("pervyi otricatelnyi chlen posledovatelnosti %f", x);
	_getch();
}