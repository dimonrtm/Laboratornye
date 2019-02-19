# include <windows.h>
# include <cmath>
# include <GL\GL.h>
# include <gl\GLU.h>
# include <gl\glut.h>
# include <ctime>
# include <iostream>
using namespace std;

void myInit()
{
	glClearColor(0.0, 0.0, 0.0, 0.0);
	glColor3f(1.0, 0.0, 0.0);
	glPointSize(1.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluOrtho2D(0.0, 640.0, 0.0, 480.0);
}

void Bresentheim(int x0, int y0, int x1, int y1)
{
	clock_t t1, t2;
	t1 = clock();
	for (int i = 0; i <= 10000; i++)
	{
		int y, s;
		int dx = abs(x1 - x0);
		int dy = abs(y1 - y0);
		int d = 0;
		s = dy;
		y = y0;
		glBegin(GL_POINTS);
		for (int x = x0; x <= x1; x++)
		{
			glVertex2i(x, y);
			d = d + s;
			if (d << 1 >= dx)
			{
				y = y - 1;
			}
			d = d - dx;
		}
		glEnd();
	}
	t2 = clock();
	cout << "Брезентхем,время выполнения " << t2 - t1 << "\n";
}

void DDA(int x1, int y1, int x2, int y2)
{
	clock_t t1, t2;
	t1 = clock();
	for (int i = 0; i <= 10000; i++)
	{
		glBegin(GL_POINTS);
		double x = x1;
		double y = y1;
		int L = max(abs((int)x2 - (int)x1), abs((int)y2) - (int)x1) + 1;
		for (int i = 0; i < L; i++)
		{
			x = x + (double)(x2 - x1) / L;
			y = y + (double)(y2 - y1) / L;
			glVertex2i(round(x), round(y));
		}
		glEnd();
	}
	t2 = clock();
	cout << "DDA, время выполнения " << t2 - t1 << "\n";
}
void MyLine(int x1, int y1, int x2, int y2)
{
	clock_t t1, t2;
	t1 = clock();
	for (int i = 0; i <= 10000; i++)
	{
		glBegin(GL_LINES);
		glVertex2i(x1, y1);
		glVertex2i(x2, y2);
		glEnd();
	}
	t2 = clock();
	cout << "GL_LINES, время выполнения " << t2 - t1 << "\n";
	}
	

void myDisplay()
{
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	Bresentheim(100,200, 200,100);
	DDA(200, 300, 300, 200);
	MyLine(300, 400, 400, 300);
	glFlush();
}

void main(int argc, char** argv)
{
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
	glutInitWindowSize(640, 480);
	glutInitWindowPosition(100, 150);
	glutCreateWindow("");
	glutDisplayFunc(myDisplay);
	myInit();
	glutMainLoop();
}