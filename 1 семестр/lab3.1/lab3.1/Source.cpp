# include <stdio.h>
# include <conio.h>
void main()
{
	int N, Sch, Sn, ost;
	printf("Vvedite chislo\n");
	scanf_s("%d", &N);
	Sch = 0;
	Sn = 0;
	for (int i = 1;i <= N;i++)
	{
		ost = i % 2;
		if (ost == 0)
		{
			Sch = Sch + i;
		}
		else
		{
			Sn = Sn + i;
		}
	}
	printf("Summa chetnih chisel %d\n", Sch);
	printf("Summa nechetnih chisel %d\n", Sn);
	_getch();
}