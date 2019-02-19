# include <stdio.h>
# include <conio.h>
void main()
{
	int A, B;
	printf("Vvedite chislo A\n");
	scanf_s("%d",& A);
	printf("Vvedite chislo B\n");
	scanf_s("%d", &B);
	while (A != B)
	{
		if (A > B)
		{
			A = A - B;
		}
		else
		{
			B = B - A;
		}
	}
	printf("NOD dannyh chisel raven %d\n", A);
		_getch();
}