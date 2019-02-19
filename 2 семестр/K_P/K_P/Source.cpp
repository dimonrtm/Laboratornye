# include <iostream>
# include<locale>
#include <Windows.h>
# include "Graph.h"
using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	int Item;
	while (1)
	{
		cout << "             Меню программы         \n";
		cout << " 1.Информация о программе \n";
		cout << " 2.Руководство пользователя \n";
		cout << " 3.Выполнение алгоритма при вводе данных с клавиатуры \n";
		cout << " 4.Выполнение алгоритма при вводе данных из файла \n";
		cout << " 5.Выход из программы \n";
		cout << " Введите номер пункта меню чтобы перейти к нему \n";
		cin >> Item;
		switch (Item)
		{
		case 1: {
			string str;
			ifstream info("info.txt");
			while (getline(info, str))
			{
				cout << str << "\n";
			}
			system("pause");
			break;
		}
		case 2: {
			string str;
			ifstream help("help.txt");
			while (getline(help, str))
			{
				cout << str << "\n";
			}
			system("pause");
			break;
		}
		case 3: {
			Graph *graph1 = new Graph;
			if (graph1->Graph_Init())
			{
				graph1->Print_Shortest_Path();
			}
			else
			{
				cout << "Вы ввели некорректные данные\n";
				system("pause");
				return 0;
			}
			delete graph1;
			system("pause");
			break;
		}
		case 4: {
			Graph *graph2 = new Graph;
			if (graph2->GrafInitFromFile())
			{
				graph2->Print_Shortest_Path();
			}
			else
			{
				cout << "Вы ввели некорректные данные\n";
			}
			delete graph2;
			system("pause");
			break;
		}
		case 5: {
			return 0;
			break;
		}
		default: {
			cout << " Введен неверный пункт меню \n";
			system("pause");
		}
		}
		system("cls");
	}


	system("pause");
}