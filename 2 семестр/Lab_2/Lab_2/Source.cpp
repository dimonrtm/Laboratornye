# include <iostream>
# include<locale>
#include <string>
#include<cstring>
#include <Windows.h>
using namespace std;
class strtype
{
private:
	char *str;
	int n;
	string *str_arr;
public:
	strtype()
	{
		str = new char[10];
	}

	strtype(char *p, int m)
	{
		str = new char[strlen(p)+1];
		strcpy_s(str,strlen(p)+1,p);
		n = m;
	}

	void drob()
	{
		int kol = strlen(str) / n;
		str_arr = new string[n];
		int m = 0;
		int ost = strlen(str) % n;
		string temp=str;
		str_arr[m].insert(0, temp,0, kol + ost);
		m++;
		for (int i = kol + ost; i < temp.length()&& m < n;i=i+kol)
		{
			str_arr[m].insert(0, temp,i, kol);
			m++;
		}
	}

	~strtype()
	{
		delete str;
		delete[]str_arr;
	}

	void print()
	{
		for (int i = 0; i < n; i++)
		{
			cout << str_arr[i] << "\n";
		}
	}
};

void main()
{
	char *stroka=new char[200];
	int n;
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	cout << "¬ведите строку\n";
	cin.getline(stroka, 200);
	cout << "¬ведите число строк после разделени€\n";
	cin >> n;
	strtype str1 =strtype(stroka, n);
	str1.drob();
	str1.print();
	system("pause");
} 