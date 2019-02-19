#include <conio.h>
#include <stdio.h>
#include <string.h>
#include <ctype.h>
# include<locale>
# include <stdlib.h>
#include <Windows.h>
using namespace std;
struct Stars
{
	char Name[15];
	double Apparent_Magnitude;
	double Absolute_Value;
	char Galaxy[20];
};
void main()
{
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int n;
	char str[15];
	printf_s("Введите количество звезд\n");
	scanf_s("%d", &n);
	struct Stars *st=new struct Stars[n];
	for (int i = 0; i < n; i++)
	{
		system("cls");
		printf("Введите название звезды\n");
		scanf_s("%s", st[i].Name, _countof(st[i].Name));
		//printf("%s", st[i].Name);
		printf("Введите видимую величину звезды\n");
		scanf_s("%lf", &st[i].Apparent_Magnitude);
		//printf("%f", st[i].Apparent_Magnitude);
		printf("Введите абсолютную величину звезды\n");
		scanf_s("%lf", &st[i].Absolute_Value);
		//printf("%lf\n", st[i].Absolute_Value);
		printf_s("Введите созвездие\n");
		scanf_s("%s", st[i].Galaxy,_countof(st[i].Galaxy));
		//printf("%s", st[i].Galaxy);
	}
	system("cls");
	printf("Введите название звезды для поиска\n");
	scanf_s("%s", str, _countof(str));
	for (int i = 0; i < n; i++)
	{
		if (!strcmp(st[i].Name,str))
		{
			printf("Название звезды - %s. Видимая величина - %lf. Абсолютная величина - %lf. Созвездие - %s.\n", st[i].Name, st[i].Apparent_Magnitude, st[i].Absolute_Value, st[i].Galaxy);
		}
	}
	_getch();
	system("cls");
	printf("Введите созвездие для поиска\n");
	scanf_s("%s", str, _countof(str));
	for (int i = 0; i < n; i++)
	{
		if (!strcmp(st[i].Galaxy, str))
		{
			printf("Название звезды - %s. Видимая величина - %lf. Абсолютная величина - %lf. Созвездие - %s.\n", st[i].Name, st[i].Apparent_Magnitude, st[i].Absolute_Value, st[i].Galaxy);
		}
	}
	delete[] st;
	_getch();
}