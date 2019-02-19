# include <stdio.h>
# include <conio.h>
# include <windows.h>
# include <GL\GL.h>
# include <gl\GLU.h>
# include <gl\glut.h>
# include <math.h>
# include <iostream>

using namespace std;
# define PI 3.14159292

double func1(double a)/*вычисляет первую функцию*/
{
	double  y;
	y = 2 * log(a + 1) - 3 * sin(2 * a) - 4;
	return y;
}

double func2(double x)/*вычисляет вторую функцию*/
{
	double y;
	y = 1 / (1 + sqrt(log(x)));
	return y;
}

double minim(double mass[16])/*находит наименьший элемент массива из 16 элементов*/
{
	double min;
	min = mass[0];
	for (int i = 1; i <= 15; i++)
	{
		if (min > mass[i])
		{
			min = mass[i];
		}
	}
	return min;
}

double maxim(double mass[16])
{
	double max = mass[0];
	for (int i = 1; i <= 15; i++)
	{
		if (max < mass[i])
		{
			max = mass[i];
		}
	}
	return max;
}

void vivodmassiva(double arr[16], double d[16], double e[16])/*вывводит на экран три массива значений на экран*/
{
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	for (int j = 0; j <= 15; j++)
	{
		if (d[j] == minim(d))
		{
			printf("%8f\t", arr[j]);
			SetConsoleTextAttribute(hConsole, (WORD)((0 << 4) | 2));
			printf("%8f\t", d[j]);
			SetConsoleTextAttribute(hConsole, (WORD)((0 << 4) | 7));
			SetConsoleTextAttribute(hConsole, (WORD)((0 << 4) | 4));
			printf("%8f\n", e[j]);
			SetConsoleTextAttribute(hConsole, (WORD)((0 << 4) | 7));
			continue;
		}
		if (d[j] == maxim(d))
		{
			printf("%8f\t", arr[j]);
			SetConsoleTextAttribute(hConsole, (WORD)((0 << 4) | 4));
			printf("%8f\t", d[j]);
			SetConsoleTextAttribute(hConsole, (WORD)((0 << 4) | 7));
			printf("%8f\n ", e[j]);
			continue;
		}
		if (e[j] == minim(e))
		{
			printf("%8f\t%8f\t", arr[j], d[j]);
			SetConsoleTextAttribute(hConsole, (WORD)((0 << 4) | 2));
			printf("%8f\n", e[j]);
			SetConsoleTextAttribute(hConsole, (WORD)((0 << 4) | 7));
			continue;
		}
		printf("%8f\t%8f\t%8f\n", arr[j], d[j], e[j]);

	}

}

void koren()/*вычисляет корень нелинейного уравнения на интервале от 1 до 10 методом бисекции */
{
	double a = 1.0, b = 10.0, e = 0.001, c;
	c = (a + b) / 2;
	while (fabs(func1(c)) > e)
	{

		if (func1(a)*func1(c) < 0)
		{
			b = c;
		}
		else
		{
			a = c;
		}
		c = (a + b) / 2;
	}
	printf("koren uravnenija 2ln(x+1)-3sin2x=4 na intervale ot 1 do 10 raven %f\n", c);
}

void metod_Pramougolnika()
{
	double a = 1.0, b = 10.0, h, xi, sum = 0.0, result;/*вычисляет интеграл методом прямоуголников*/
	int N = 300;
	h = (b - a) / N;
	for (int i = 1; i <= N; i++)
	{
		xi = a + (i - 0.5)*h;
		sum = sum + func2(xi);
	}
	result = sum*h;
	printf("znachenie integrala vichislennoe metodom prjamougolnikov ravno %f\n", result);
}

void metod_Trapecii()
{
	double a = 1.0, b = 10.0, h, xi, sum = 0.0, tr, result;/*вычисляет интеграл методом трапеции*/
	int N = 300;
	h = (b - a) / N;
	tr = (func2(a) + func2(b)) / 2;
	for (int i = 1; i <= N - 1; i++)
	{
		xi = a + i*h;
		sum = sum + func2(xi);
	}
	result = h*(tr + sum);
	printf("znachenie integrala vichislennoe metodom trapecii ravno %f", result);
}


void myInit()
{
	glClearColor(1.0, 1.0, 1.0, 0.0);
	glColor3f(0.0, 0.0, 0.0);
	glPointSize(4.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluOrtho2D(0.0, 640.0, 0.0, 480.0);
}


void myDisplay()
{
	GLdouble A, B, C, D, x;
	const int screenWidth = 640;
	const int screenHeidth = 480;
	A = screenWidth / 12.0;
	B = 40;
	C = screenHeidth / 10.0;
	D = 2 * screenHeidth / 5.0 + 70;
	glClear(GL_COLOR_BUFFER_BIT);
	glBegin(GL_LINES);
	glVertex2d(0 * A + B, 7 * C + D);
	glVertex2d(0 * A + B, -5.34 * C + D);
	glVertex2d(0*A+B, 0 * C + D);
	glVertex2d(12 * A + B, 0 * C + D);
	glEnd();
		glPointSize(1.0);
		glColor3f(0.0, 0.0, 0.0);
	glBegin(GL_LINE_STRIP);
	for (x = 1; x <= 11; x += 0.001)
	{
		glVertex2d(A*x + B, C*func1(x) + D);
	}
	glEnd();
	glFlush();
}


void MyDisplay2()
{
	GLdouble A, B, C, D, x;
	const int screenWidth = 640;
	const int screenHeidth = 480;
	A = screenWidth / 13.0;
	B = A;
	C = screenHeidth / 4.0;
	D =  screenHeidth /2.0;
	glClear(GL_COLOR_BUFFER_BIT);
	glBegin(GL_LINES);
	glVertex2d(0 * A + B, -2 * C + D);
	glVertex2d(0 * A + B, 2 * C + D);
	glVertex2d(-1*A+B, 0 * C + D);
	glVertex2d(12 * A + B, 0 * C + D);
	glEnd();
	glPointSize(1.0);
	glColor3f(0.0, 0.0, 0.0);
	glBegin(GL_LINE_STRIP);
	for (x = 1; x <= 11; x += 0.001)
	{
		glVertex2d(A*x + B, C*func2(x) + D);
	}
	glEnd();
	glFlush();
}

int main(int argc,char**argv)
{
	double b = 11.0, n = 16.0, a = 1.0, y1[16], y2[16], xi[16];
	int i = 0;
	char vibor;
	for (double x = a; x <= b&&i <= 15; x = x + (10 / n))
	{
		xi[i] = x;
		y1[i] = func1(x);
		y2[i] = func2(x);
		i++;
	}
	while (true)
	{
		cout << "Vvedite a chtoby vyvesti grafik pervoi funkcii\n";
		cout << "Vvedite b chtoby vyvesti grafic vtoroi funkcii\n";
		cout << "Vvedite c chtoby vyvesti tablicu znachenii funkcii\n";
		cout << "Vvedite d chtoby vyvesti koren nelineinogo uravneniya\n";
		cout << "Vvedite e chtoby vyvesti znacheniya integrala\n";
		cout << "Vvedite f chtoby vyiti iz programmy\n";
		cin >> vibor;
		switch (vibor)
		{
		case 'a': {glutInit(&argc, argv);
			glutInitDisplayMode(GLUT_SINGLE || GLUT_RGB);
			glutInitWindowSize(640, 480);
			glutInitWindowPosition(100, 150);
			glutCreateWindow("Grafic 1");
			glutDisplayFunc(myDisplay);
			myInit();
			glutMainLoop();
			 break; }
		case 'b': {glutInit(&argc, argv);
			glutInitDisplayMode(GLUT_SINGLE || GLUT_RGB);
			glutInitWindowSize(640, 480);
			glutInitWindowPosition(100, 150);
			glutCreateWindow("Grafic 2");
			glutDisplayFunc(MyDisplay2);
			myInit();
			glutMainLoop();
			  break; }
		case 'c': {printf("x\t             y1\t             y2\n");
			vivodmassiva(xi, y1, y2);
			break;
		}
		case 'd': {koren(); break; }
		case 'e': {	metod_Pramougolnika();
			metod_Trapecii();  break; }
		case 'f':{return 0; break; }
		default: {cout << "Vy vveli nevernoe znachenie\n"; }
		}
		system("pause");
		system("cls");
	} 
	
	_getch();
}