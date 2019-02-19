#include <conio.h>
#include <stdio.h>
# include<locale>
# include <malloc.h>
#include <Windows.h>
using namespace std;

typedef struct int_List
{
	int data;
	struct int_List *next;
	struct int_List *prev;
}int_List;

void add(int_List **sPtr, int value) {
	int_List *x = (int_List*)malloc(sizeof(int_List));
x->data = value;
x->next = *sPtr;
if (*sPtr != NULL)
{
	(*sPtr)->prev = x;
	*sPtr = x;
	x->prev = NULL;
}
}
int_List* init(int Data)
{
	int_List *first = (int_List*)malloc(sizeof(int_List));
	first->data = Data;
	first->next = NULL;
	first->prev = NULL;
	return first;
}

void print(int_List *Ptr)
{
	if (Ptr == NULL)
	{
		printf("Ћист пуст\n");
	}
	else
	{
		while (Ptr != NULL)
		{
			printf("%d ", Ptr->data);
			Ptr = Ptr->next;
		}
	}
}


void sort(int_List **sPtr)
{
	int_List *curr = NULL;
	int_List *second = NULL;
	int_List *c = NULL;
	int_List*e = NULL;
	int_List *tmp = NULL;

	while (e != (*sPtr)->next)
	{
		c = curr = *sPtr;
		second = curr->next;
		while (curr != e)
		{
			if (curr->data > second->data)
			{
				if (curr == *sPtr)
				{
					tmp = second->next;
					second->next = curr;
					curr->next = tmp;
					*sPtr = second;
					c = second;
				}
				else
				{
					tmp = second->next;
					second->next = curr;
					curr->next = tmp;
					c->next = second;
					c = second;
				}
			}
			else
			{
				c = curr;
				curr = curr->next;
			}
			second = curr->next;
			if (second == e)
				e = curr;
		}
	}
}



void main()
{
	int Data;
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	printf("¬ведите число:\n");
	scanf_s("%d", &Data);
	int_List *stPtr=init(Data);
	int_List *End = stPtr->next;
	int_List *tmpPtr=NULL;
	system("cls");
	printf("¬ведите число:\n");
	while ((scanf_s("%d", &Data)))
	{
		add(&stPtr, Data);
		system("cls");
		printf("¬ведите число:\n");
	}
	sort(&stPtr);
	int_List *current = stPtr;
	while (current != NULL&&current->next != NULL)
	{
		if (current->data == current->next->data)
		{
			if (current->next->next == NULL)
			{
				free(current->next);
				current->next = NULL;
			}
			else
			{
				tmpPtr = current->next->next;
				free(current->next);
				current->next = tmpPtr;
				tmpPtr->prev = current;
			}
		}
		else
		{
			current = current->next;
		}
	}
	print(stPtr);
	_getch();
}
