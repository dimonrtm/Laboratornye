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
	glVertex2d(0 * A + B, 0 * C + D);
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
	D = screenHeidth / 2.0;
	glClear(GL_COLOR_BUFFER_BIT);
	glBegin(GL_LINES);
	glVertex2d(0 * A + B, -2 * C + D);
	glVertex2d(0 * A + B, 2 * C + D);
	glVertex2d(-1 * A + B, 0 * C + D);
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

int main(int argc, char**argv)
{
	char vibor;
	while (true)
	{
		cout << "Vvedite a chtoby vyvesti grafik pervoi funkcii\n";
		cout << "Vvedite b chtoby vyvesti grafic vtoroi funkcii\n";
		cout << "Vvedite c chtoby vyiti iz programmy\n";
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
		case 'c':{return 0; break; }
		default: {cout << "Vy vveli nevernoe znachenie\n"; }
		}
		system("pause");
		system("cls");
	}

	_getch();
}

