# include <iostream>
# include<locale>
#include <Windows.h>
using namespace std;
class Complex
{
protected:
	double Real;
	double Im;
public:
	Complex()
	{
		Real = 0;
		Im = 0;
	}

	Complex(double real, double im)
	{
		Real = real;
		Im = im;
	}
	friend Complex operator +(Complex, Complex);
	friend Complex operator *(Complex, Complex);
	void printf()
	{
		cout << Real << " + i" << Im << "\n";
	}
};

Complex operator +(Complex a, Complex b)
{
	Complex summ;
	summ.Real = a.Real + b.Real;
	summ.Im = a.Im + b.Im;
	return summ;
}

Complex operator *(Complex a, Complex b)
{
	Complex proizv;
	proizv.Real = a.Real*b.Real - a.Im*b.Im;
	proizv.Im = a.Im*b.Real + a.Real*b.Im;
	return proizv;
}

void main()
{
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	double Real, Im;
	Complex summ, proizv;
	cout << "������� �������������� ����� ����� a\n";
	cin >> Real;
	cout << "������� ������ ����� ����� a\n";
	cin >> Im;
	Complex a = Complex(Real, Im);
	cout << "������� �������������� ����� ����� b\n";
	cin >> Real;
	cout << "������� ������ ����� ����� b\n";
	cin >> Im;
	Complex b = Complex(Real, Im);
	cout << "����� a\n";
	a.printf();
	cout << "����� b\n";
	b.printf();
	summ = a + b;
	cout << "�����:\n";
	summ.printf();
	proizv = a*b;
	cout << "������������:\n";
	proizv.printf();
	system("pause");
}