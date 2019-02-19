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
		cout << "             ���� ���������         \n";
		cout << " 1.���������� � ��������� \n";
		cout << " 2.����������� ������������ \n";
		cout << " 3.���������� ��������� ��� ����� ������ � ���������� \n";
		cout << " 4.���������� ��������� ��� ����� ������ �� ����� \n";
		cout << " 5.����� �� ��������� \n";
		cout << " ������� ����� ������ ���� ����� ������� � ���� \n";
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
				cout << "�� ����� ������������ ������\n";
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
				cout << "�� ����� ������������ ������\n";
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
			cout << " ������ �������� ����� ���� \n";
			system("pause");
		}
		}
		system("cls");
	}


	system("pause");
}