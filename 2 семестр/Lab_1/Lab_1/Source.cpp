# include <iostream>
# include<locale>
#include <Windows.h>
using namespace std;
class List
{
protected:
	int Data;
	List *next;
public:
	friend class QUEUE;
	List();
};
List::List()
{
;
}

class QUEUE
{
private:
	List *Head;
	List *tail;
public:
	QUEUE();
	~QUEUE();
	void Add(int Data);
	int delqueue();
	void print();

};
QUEUE::QUEUE()
{
	Head = NULL;
	tail = NULL;
}
void QUEUE::Add(int Data)
{
	List *x = new List;
	x->Data = Data;
	x->next = NULL;
	if (Head == NULL)
	{	
		Head = x;
	}
	else
	{
		tail->next = x;
	}
	tail = x;
}

int QUEUE::delqueue()
{
	List *temp;
	int value;
		value = Head->Data;
		temp = Head;
		Head = Head->next;
		delete temp;
	if (Head == NULL)
	{
		tail = NULL;
	}
	return value;
}

void QUEUE::print()
{
	List *current = Head;
	while (current != NULL)
	{
		cout << current->Data<<" ";
		current = current->next;
	}
	cout << "\n";
}

QUEUE::~QUEUE()
{
	while (Head != NULL)
	{
		delqueue();
	}
}

void main()
{
	QUEUE q;
	int data;
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	cout << "Введите число\n";
	while (cin >> data)
	{
		q.Add(data);
		system("cls");
		cout << "Введите число\n";
	}
	q.print();
	cout << "Удален элемент " << q.delqueue() << "\n";
	q.print();
	system("pause");
}