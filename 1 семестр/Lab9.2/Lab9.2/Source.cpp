# include <stdio.h>
# include <conio.h>
# include <clocale>
using namespace std;

int summa(int a[2][3], int b[2][3], int *result)
{
	int res1=0,res2=0;
	for (int i = 0; i <= 1; i++)
	{
		for (int j = 0; j <= 2; j++)
		{
			res1 = res1 + a[i][j];
			res2 = res2 + b[i][j];
		}
	}
	*result = res2;
	return res1;
	
}

void main()
{
	setlocale(LC_CTYPE, "rus");
	int V[2][3] = { {1,2,3},{4,5,6} }, W[2][3] = { {7,8,9},{10,11,12} },summ1,summ2=0;
	summ1 = summa(V, W, &summ2);
	printf("Сумма элементов строк первой матрицы равна %d\n", summ1);
	printf("Сумма элементов строк второй матрицы равна %d\n", summ2);
	_getch();
}