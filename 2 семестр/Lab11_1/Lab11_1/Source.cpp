# include <stdio.h>
# include <conio.h>
# include <clocale>
# include <Windows.h>
# include <stdlib.h>
using namespace std;

int summa(int a[2][3], int b[2][3], int *result)
{
	int res1 = 0, res2 = 0;
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
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int V[2][3], W[2][3], summ1, summ2 = 0;
	FILE *vvod, *vivod;
	if (fopen_s(&vvod,"Vvod.txt","r"))
	{
		puts("Не могу открыть файл!\n");
		exit(1);
	}
	puts("Файл отрыт!\n");
	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			fscanf_s(vvod, "%d", &V[i][j]);
		}
	}
	for (int k = 0; k < 2; k++)
	{
		for (int l = 0; l < 3; l++)
		{
			fscanf_s(vvod, "%d",&W[k][l]);
		}
	}
	fclose(vvod);
	summ1 = summa(V, W, &summ2);
	fopen_s(&vivod, "Vivod.txt", "w");	
	fprintf_s(vivod,"Сумма элементов строк первой матрицы равна %d\n", summ1);
	fprintf_s(vivod,"Сумма элементов строк второй матрицы равна %d\n", summ2);
	fclose(vivod);
	_getch();
}