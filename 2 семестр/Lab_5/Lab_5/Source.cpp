# include <iostream>
# include<locale>
#include <Windows.h>
using namespace std;

class Date
{
protected:
	int Day;
	int Month;
	int Year;

	void PrintFormatDayMonth()
	{
		if (Day < 10)
		{
			cout << "0" << Day << ".";
		}
		else
		{
			cout << Day << ".";
		}
		if (Month < 10)
		{
			cout << "0" << Month << ".";
		}
		else
		{
			cout << Month << ".";
		}
	}

public:
	Date()
	{
		Day = 0;
		Month = 0;
		Year = 0;
	}

	Date(int day, int month, int year)
	{
		Day = day;
		Month = month;
		Year = year;
	}

	friend Date NextDate(Date date, int n);

	int CheckYear()
	{
		if (!(Year % 400))
		{
			return 1;
		}
		else
		{
			if (!(Year % 100))
			{
				return 0;
			}
			else
			{
				if (!(Year % 4))
				{
					return 1;
				}
			}
		}
		return 0;
	}

	

	void print()
	{
		PrintFormatDayMonth();
		cout << Year << "\n";
		/*if (Day < 10)
		{
			if (Month < 10)
			{
				cout << "0" << Day << "." << "0" << Month << "." << Year << "\n";
			}
			else
			{
				cout << "0" << Day << "." << Month << "." << Year << "\n";
			}
		}
		else
		{
			if (Month < 10)
			{
				cout << Day << "." << "0" << Month << "." << Year << "\n";
			}
			else
			{
				cout << Day << "." << Month << "." << Year << "\n";
			}
		}*/
	}
	void NextDay(int MaxDay,int &n)
	{
		if (Month == 12)
		{
			if (Day < MaxDay)
			{
			Day++;
			n--;
			}
			if (Day == MaxDay)
			{
			Day = 1;
			Month = 1;
		    Year++;
			n--;
			}
		}
		else
		{
			if (Day <MaxDay)
			{
			Day++;
			n--;
			}
			if (Day == MaxDay)
			{
			Day = 1;
			Month++;
			n--;
			}
		}
	}
};

Date NextDate(Date date, int n)
{
	
	while (n != 0)
	{
		switch (date.Month)
		{
		case 1:case 3:case 5:case 7:case 8:case 10: {
				date.NextDay(31,n);
			/*if (date.Day < 31)
			{
				date.Day++;
				n--;
			}
			if (date.Day == 31)
			{
				date.Day = 1;
				date.Month++;
				n--;
			}*/
			break;
		}
		case 2: {
			if(date.CheckYear())
			{
				date.NextDay(29,n);
				/*if (date.Day < 29)
				{
					date.Day++;
					n--;
				}
				if (date.Day == 29)
				{
					date.Day = 1;
					date.Month++;
					n--;
				}*/
			}
			else
			{
				date.NextDay(28,n);
				//if (date.Day < 28)
				//{
				//	date.Day++;
				//	n--;
				//}
				//if (date.Day == 28)
				//{
				//	date.Day = 1;
				//	date.Month++;
				//	n--;
				//}
			}
			break;
		}
		case 4:case 6:case 9:case 11: {
			date.NextDay(30,n);
			/*if (date.Day < 30)
			{
				date.Day++;
				n--;
			}
			if (date.Day == 30)
			{
				date.Day = 1;
				date.Month++;
				n--;
			}*/
			break;
		}
		case 12: {
			date.NextDay(31,n);
			/*if (date.Day < 31)
			{
				date.Day++;
				n--;
			}
			if (date.Day == 31)
			{
				date.Day = 1;
				date.Month = 1;
				date.Year++;
				n--;
			}*/
			break;
		}
		default: {
			cout << "Такого месяца не существует\n";
			break;
		}
		}
	}
		return date;


}

void main()
{
	int Day, Month, Year, n;
	Date Current, Next;
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	cout << "Введите число\n";
	cin >> Day;
	cout << "Введите месяц \n";
	cin >> Month;
	cout << "Введите год\n";
	cin >> Year;
	Current = Date(Day, Month, Year);
	cout << "Текущая дата:\n";
	Current.print();
	cout << "Введите количество прошедших дней\n";
	cin >> n;
	Next = NextDate(Current, n);
	cout << "Новая дата\n";
	Next.print();
	system("pause");
}