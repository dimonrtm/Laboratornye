
# include <conio.h>
# include <string.h>
# include <ctype.h>
# include <locale>
# include <iostream>
# include <windows.h>
using namespace std;
void main()
{
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	char str1[26], str2[32];
	/*cin >> str4;
	//cout<< str3<<"\n";
	cout<< str4<<"\n";*/
	int j=0;
	for (int i = 97; i <= 122&&j<=25; i++)
	{
		str1[j] =(unsigned char) i;
		j++;
	}
	j = 0;
	for (int i = 224; i <= 255&&j<32; i++)
	{
		str2[j] =(unsigned char) i;
		j++;
	}
	for (int i = 0; i <= 25; i++)
	{
		cout << str1[i];
	}
	//cout<< str1<<"\n";
	cout<<"\n";
	for (int i = 0; i <= 25; i++)
	{
		str1[i] = toupper(str1[i]);
	}
	/*for (int i = 0; i < 25; i++)
	{
		str1[i] = str1[i] - 32;
	}*/
	//cout<< str1<<"\n";
	for (int i = 0; i <= 25; i++)
	{
		cout << str1[i];
	}
	cout<<"\n";
	//cout<< str2<<"\n";
	for (int i = 0; i < 32; i++)
	{
		cout << str2[i];
	}
	for (int r2 = 0; r2 < 32; r2++)
	{
		str2[r2] = toupper(str2[r2]);
	}
	cout<<"\n";
		//cout<< str2<<"\n";
	for (int i = 0; i < 32; i++)
	{
		cout << str2[i];
	}
	cout<<"\n";
	/*for (int i = 0; i < 33; i++)
	{
			str2[i] = str2[i] - 32;
	}
	printf("%s\n",str2);
	/*for (int i = 128; i <= 159; i++)
	{
		printf("%c ", i);
	}
	printf("\n");
	for (int i = 0; i <= 255;i++)
	{
		printf("%c %d\n", (char)i,i);
	}*/
	_getch();
}