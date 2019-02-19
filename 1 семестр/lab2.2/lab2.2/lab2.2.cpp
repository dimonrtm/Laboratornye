# include <stdio.h>
#include <conio.h>
void main()
{
	int N;
	scanf_s("%d", &N);
	switch (N)
	{
	case 0:case 1:case 2:case 3:case 4:case 5:case 6:case 7:case 8:case 9: printf("%d\n", N);break;
	case 10: printf("A\n");break;
	case 11: printf("B\n");break;
	case 12: printf("C\n");break;
	case 13: printf("D\n");break;
	case 14: printf("E\n");break;
	case 15: printf("F\n");break;
	default: printf("Nevernoe chislo");
	}
	_getch();
}