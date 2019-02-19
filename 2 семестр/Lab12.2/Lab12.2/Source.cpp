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
void WriteData(int n,FILE *f,char *str)
{
	char name[15];
	double AM;
	double AV;
	char galaxy[20];
	for (int i = 0; i < n; i++)
	{
		system("cls");
		printf("Введите название звезды\n");
		scanf_s("%s", name, _countof(name));
		printf("Введите видимую величину звезды\n");
		scanf_s("%lf", &AM);
		printf("Введите абсолютную величину звезды\n");
		scanf_s("%lf", &AV);
		printf_s("Введите созвездие\n");
		scanf_s("%s", galaxy, _countof(galaxy));
		fprintf(f, "%s\t%lf\t%lf\t%s\n", name, AM, AV, galaxy);
	}
	fclose(f);
}
void main()
{
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int n;
	FILE *f;
	char str[15];
	char nameFile[9];
	printf("Введите количество звезд\n");
	scanf_s("%d", &n);
	printf("Введите имя файла для сохранения\n");
	scanf_s("%s", nameFile, _countof(nameFile));
	struct Stars *st = new struct Stars[n];
//	fopen_s(&f, nameFile, "w");
	//WriteData(n,f, nameFile);
	if (fopen_s(&f, nameFile, "r"))
	{
		puts("Не могу открыть файл!\n");
		exit(1);
	}
	puts("Файл отрыт!\n");
	for (int i = 0; i < n; i++)
	{
		fscanf_s(f, "%s%lf%lf%s", st[i].Name, _countof(st[i].Name), &st[i].Apparent_Magnitude, &st[i].Absolute_Value, st[i].Galaxy, _countof(st[i].Galaxy));
	}
	fclose(f);
	system("cls");
	printf("Введите название звезды для поиска\n");
	scanf_s("%s", str, _countof(str));
	for (int i = 0; i < n; i++)
	{
		if (!strcmp(st[i].Name, str))
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