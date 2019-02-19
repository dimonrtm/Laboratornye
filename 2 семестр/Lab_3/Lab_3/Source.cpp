# include <iostream>
# include<locale>
#include <Windows.h>
using namespace std;

class List_template
{
protected:
	int Data;
	List_template *next;
	List_template *prev;
public:
	List_template()
	{
		;
	}
	friend class Stack;
	friend class Deck;
};

class Stack
{
protected:
	List_template *Head;
public:
	Stack()
	{
		Head = NULL;
	}

	void Push(int data)
	{
		List_template *x=new List_template;
		x->Data = data;
		if (Head == NULL)
		{
			x->next = NULL;
			x->prev = NULL;
			Head = x;
		}
		else
		{
			x->next = Head;
			x->prev = NULL;
			Head = x;
		}
	}

	int Pop()
	{
		int value;
		List_template *temp;
		if (Head != NULL)
		{
			value = Head->Data;
			temp = Head;
			Head = Head->next;
			delete temp;
			return value;
		}
		else
		{
			cout << "—тек пуст\n";
			return 0;
		}
		
	}

	void print()
	{
		List_template *Current;
		Current = Head;
			while (Current != NULL)
			{
					cout << Current->Data << " ";
					Current = Current->next;
			}
			cout << "\n";
		
	}
	~Stack()
	{
		while (Head != NULL)
		{
			Pop();
		}
	}
};

class Deck :public Stack
{
private:
	List_template *End;
public:

	Deck()
	{
		Head = NULL;
		End = NULL;
	}

	void AddLeft(int data)
	{
		List_template *x = new List_template;
		x->Data = data;
		if (Head == NULL)
		{
			x->next = NULL;
			x->prev = NULL;
			Head = x;
			End = x;
		}
		else
		{
			Head->prev = x;
			x->next = Head;
			x->prev = NULL;
			Head = x;
		}
	}

	int Delete_Left()
	{
		int value;
		List_template *temp;
		if (Head != NULL)
		{
			if (Head->next == NULL)
			{
				value = Head->Data;
				temp = Head;
				Head = NULL;
				End = NULL;
				delete temp;
				return value;
			}
			else
			{
				value = Head->Data;
				temp = Head;
				Head->next->prev = NULL;
				Head = Head->next;
				delete temp;
				return value;
			}
		}
		else
		{
			cout << "ƒек пуст\n";
			return 0;
		}
		
	}

	void Add_Right(int data)
	{
		List_template *x = new List_template;
		x->Data = data;
		if (Head == NULL)
		{
			x->next = NULL;
			x->prev = NULL;
			Head = x;
			End = x;
		}
		else
		{
			x->next = NULL;
			x->prev = End;
			End->next = x;
			End = x;
		}
	}

	int Delete_Right()
	{
		int value;
		List_template *tmp;
		if(End!=NULL)
		{
			if (End->prev == NULL)
			{
				value = End->Data;
				tmp = End;
				End = NULL;
				Head = NULL;
				delete tmp;
				return value;
			}
			else
			{
				tmp = End;
				value = End->Data;
				End->prev->next = NULL;
				End = End->prev;
				delete tmp;
				return value;
			}
		}
		else
		{
			cout << "ƒек пуст\n";
			return 0;
		}
		//List_template *Current;
		//List_template *temp;
		//Current = Head;
		//if (Head != NULL)
		//{
		//	
		//	/*	value = Head->Data;
		//		temp = Head;
		//		Head = NULL;
		//		delete temp;
		//		return value;
		//	}*/
		//	while (Current != NULL)
		//	{
		//		if (Current->next == NULL)
		//		{
		//			value = Current->Data;
		//			temp = Current;
		//			Current = NULL;
		//			End = NULL;
		//			delete temp;
		//		}
		//		else
		//		{
		//			if (Current->next->next == NULL)
		//			{
		//				value = Current->next->Data;
		//				temp = Current->next;
		//				Current->next = NULL;
		//				End = Current;
		//				delete temp;
		//			}
		//		}
		//		if (Current != NULL)
		//		{
		//			Current = Current->next;
		//		}
		//	}
		//	return value;
		//}
		//else
		//{
		//	cout << "ƒек пуст\n";
		//	return 0;
		//}
		
	}
	~Deck()
	{
		while (Head != NULL)
		{
			Delete_Left();
		}
	}
};

int main()
{
	Deck deck2;
	Deck deck1;
	int Item, Data;
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	while (1)
	{
		cout << "¬ведите 1 чтобы добавить элемент в стек\n";
		cout << "¬ведите 2 чтобы удалить элемент из стека\n";
		cout << "¬ведите 3 чтобы добавить элемент в дек слева\n";
		cout << "¬ведите 4 чтобы удалить элемент из дека слева\n";
		cout << "¬ведите 5 чтобы добавить элемент в дек справа\n";
		cout << "¬ведите 6 чтобы удалить элемент из дека справа\n";
		cout << "¬ведите 7 чтобы выйти из программы\n";
		cin >> Item;
		switch (Item)
		{
		case 1: {
			system("cls");
			cout << "¬ведите число\n";
			cin >> Data;
			deck2.Push(Data);
			cout << "¬аш стек\n";
			deck2.print();
			break;
		}
		case 2: {
			system("cls");
			deck2.Pop();
			cout << "¬аш стек\n";
			deck2.print();
			break;
		}
		case 3: {
			system("cls");
			cout << "¬ведите число\n";
			cin >> Data;
			deck1.AddLeft(Data);
			cout << "¬аш дек\n";
			deck1.print();
			break;
		}
		case 4: {
			system("cls");
			deck1.Delete_Left();
			cout << "¬аш дек\n";
			deck1.print();
			break;
		}
		case 5: {
			system("cls");
			cout << "¬ведите число\n";
			cin >> Data;
			deck1.Add_Right(Data);
			cout << "¬аш дек\n";
			deck1.print();
			break;
		}
		case 6: {
			system("cls");
			deck1.Delete_Right();
			cout << "¬аш дек\n";
				deck1.print();
			break;
		}
		case 7: {
			deck2.~Deck();
			deck1.~Deck();
			return 0;
			break;
		}
		default: {
			cout << "„исло неверно\n";
			break;
		}
		}
	}
} 