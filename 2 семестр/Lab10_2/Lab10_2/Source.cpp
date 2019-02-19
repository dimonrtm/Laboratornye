#include <conio.h>
#include <stdio.h>
#include <string.h>
#include <ctype.h>
# include<locale>
# include <stdlib.h>
#include <Windows.h>
using namespace std;
void Encrypt(char *str, int n, int size)
{
	for (int i = 0; i < size; i++)
	{
		if (str[i] != NULL)
		{
			str[i] = str[i] + n;
		}
	}
}
void Decrypt(char *str, int n, int size)
{
	for (int i = 0; i < size; i++)
	{
		if (str[i] != NULL)
		{
			str[i] = str[i] - n;
		}
	}
}
void main()
{
	char str_arr[5][120];
	int n;
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	printf_s("Введите текст\n");
	for (int i = 0; i < 5; i++)
	{
		fgets(str_arr[i], 120, stdin);
	}
	printf_s("Введите число n\n");
	scanf_s("%d", &n);
	printf_s("Зашифрованный текст\n");
	for (int i = 0; i < 5; i++)
	{
		Encrypt(str_arr[i], n, 120);	
		printf_s("%s\n", str_arr[i]);
	}
	printf_s("Расшифрованный текст\n");
	for (int i = 0; i < 5; i++)
	{
		Decrypt(str_arr[i], n, 120);	
		printf_s("%s\n", str_arr[i]);
	}
	_getch();
}