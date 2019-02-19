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
	glClearColor(1.0, 1.0, 1.0, 0.0);
	glColor3f(0.0, 0.0, 0.0);
	glPointSize(1.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluOrtho2D(0.0, 640.0, 0.0, 480.0);
}

void myDisplay()
{
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	glBegin(GL_QUADS);
	glColor3f(0.0, 0.0, 1.0);
	glVertex2i(0, 50);
	glColor3f(0.0, 1.0, 0.0);
	glVertex2i(50, 150);
	glColor3f(1.0,0.0,0.0 );
	glVertex2i(150, 150);
	glColor3f(1.0, 1.0, 0.0);
	glVertex2i(200, 50);
	glEnd();
	glShadeModel(GL_FLAT);
	glBegin(GL_QUADS);
	glColor3f(0.0, 0.0, 1.0);
	glVertex2i(300, 50);
	glColor3f(0.0, 1.0, 0.0);
	glVertex2i(350, 150);
	glColor3f(1.0, 0.0, 0.0);
	glVertex2i(450, 150);
	glColor3f(1.0, 1.0, 0.0);
	glVertex2i(500, 50);
	glEnd();
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