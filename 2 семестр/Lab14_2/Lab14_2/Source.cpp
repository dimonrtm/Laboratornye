#include <conio.h>
#include <stdio.h>
#include <string.h>
#include <ctype.h>
# include<locale>
# include <stdlib.h>
#include <Windows.h>
using namespace std;

typedef struct int_Stack
{
	int Data;
	int_Stack *next;
} int_Stack;

void Push(int_Stack **Head,int value)
{
	int_Stack *new_Elem = (int_Stack *)malloc(sizeof(int_Stack));
	if (new_Elem != NULL)
	{
		new_Elem->Data = value;
		new_Elem->next = *Head;
		*Head = new_Elem;
	}
	else
	{
		printf("Нет доступной памяти\n");
	}
}

int check_Stack(int_Stack *Ptr,int value)
{
	int n = 0;
	while (Ptr != NULL)
	{
		if (Ptr->Data == value)
		{
			n++;
		}
		Ptr = Ptr->next;
	}
	return n;
}

int Pop(int_Stack**Head)
{
	int_Stack *Temp;
	int Value;
	Temp = *Head;
	Value = (*Head)->Data;
	*Head = (*Head)->next;
	free(Temp);
	return Value;
}

void main()
{
	int_Stack *Head=NULL;
	int Data;
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	printf("Введите число:\n");
	while (scanf_s("%d", &Data) == 1)
	{
		if (!check_Stack(Head, Data))
		{
			Push(&Head, Data);
		}
		system("cls");
		printf("Введите число:\n");
	}
	while (Head != NULL)
	{
		printf("%d ", Pop(&Head));
	}
	_getch();
}