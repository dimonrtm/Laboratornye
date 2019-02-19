#include <conio.h>
#include <stdio.h>
#include <string.h>
#include <ctype.h>
# include<locale>
# include <stdlib.h>
#include <Windows.h>
using namespace std;
void main()
{
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	char str[255];
	char strmin[255];
	int min;
	FILE *T, *out;
	if (fopen_s(&T, "T.txt", "r"))
	{
		puts("Не могу открыть файл\n");
		exit(1);
	}
	puts("Файл открыт\n");
	fgets(str, 252, T);
	min = strlen(str);
	strcpy_s(strmin, str);
	while (!feof(T))
	{
		fgets(str, 252, T);
		if (strlen(str) < min)
		{
			min = strlen(str);
			strcpy_s(strmin, str);
		}
	}
	fclose(T);
	fopen_s(&out, "out.txt", "w");
	fputs(strmin, out);
	fclose(out);
	_getch();
}