# include <stdio.h>
# include <conio.h>
# include <clocale>
# include "My_Header.h"
using namespace std;

extern int V[2][3], W[2][3];

void main()
{
	setlocale(LC_CTYPE, "rus");
	int summ1, summ2 = 0;
	summ1 = summa(V, W, &summ2);
	printf("Сумма элементов строк первой матрицы равна %d\n", summ1);
	printf("Сумма элементов строк второй матрицы равна %d\n", summ2);
	_getch();
}