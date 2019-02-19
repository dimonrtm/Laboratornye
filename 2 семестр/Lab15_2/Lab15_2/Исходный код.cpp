# include <stdio.h>
# include <conio.h>
# include <windows.h>
# include <GL\GL.h>
# include <gl\GLU.h>
# include <gl\glut.h>
# include <math.h>
# include <iostream>

using namespace std;

GLdouble X=0;
void myInit()
{
	glClearColor(1.0, 1.0, 1.0, .0);
	glColor3f(1.0, 0.0, 0.0);
	glPointSize(4.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluOrtho2D(0.0, 640.0, 0.0, 480.0);
}

void myDisplay()
{
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	glBegin(GL_LINES);
		glVertex2d(X + 0, 0);
		glVertex2d(X + 20, 20);
		glVertex2d(X + 20, 20);
		glVertex2d(X + 20, 0);
		glVertex2d(X + 20, 20);
		glVertex2d(X + 20, 40);
		glVertex2d(X + 0, 30);
		glVertex2d(X + 40, 30);
		glVertex2d(X + 10, 40);
		glVertex2d(X + 30, 40);
		glVertex2d(X + 10, 40);
		glVertex2d(X + 10, 60);
		glVertex2d(X + 10, 60);
		glVertex2d(X + 30, 60);
		glVertex2d(X + 30, 60);
		glVertex2d(X + 30, 40);
		glEnd();
		glutSwapBuffers();
}

void idle()
{
	for (int i = 0; i <= 500000; i++)
	{
		;
	}
	X++;
	if (X == 620)
	{
		X = 0;
	}
	glutPostRedisplay();
}

int main(int argc, char**argv)
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE| GLUT_RGB);
	glutInitWindowSize(640, 480);
	glutInitWindowPosition(100, 150);
	glutCreateWindow("Grafic 1");
	glutDisplayFunc(myDisplay);
	glutIdleFunc(idle);
	myInit();
	glutMainLoop();
	system("pause");
}