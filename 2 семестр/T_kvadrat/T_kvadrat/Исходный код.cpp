# include <windows.h>
# include <math.h>
# include <GL\GL.h>
# include <gl\GLU.h>
# include <gl\glut.h>

void myInit()
{
	glClearColor(1.0, 1.0, 1.0,0.0);
	glColor3f(1.0, 1.0, 1.0);
	glPointSize(1.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	glOrtho(-4.0, 4.0, -4.0, 4.0, -4.0, 4.0);
}

void quad(double x1, double y1, double x2, double y2)
{
	glBegin(GL_QUADS);
	glVertex3d(x1, y1,0.0);
	glVertex3d(x1, y2,0.0);
	glVertex3d(x2, y2,0.0);
	glVertex3d(x2, y1,0.0);
	glEnd();
}
void T_kvadrat(double x, double y, double l,  int n)
{
	double x1,y1,x2,y2;
	x1 = x - l / 4;
	x2 = x + l / 4;
	y1 = y + l / 4;
	y2 = y - l / 4;
	glColor3f(1.0, 0.0, 0.0);
	quad(x1, y1, x2, y2);
	if (n > 0)
	{
		T_kvadrat(x1, y1, l / 2, n - 1);
		T_kvadrat(x2, y2, l / 2, n - 1);
		T_kvadrat(x1, y2, l / 2, n - 1);
		T_kvadrat(x2, y1, l / 2, n - 1);
	}
}
void myDisplay()
{
	double x = 0.0, y = 0.0,l=8.0;
	glColor3f(0.0, 0.0, 1.0);
	quad(-4.0, 4.0, 4.0, -4.0);
	T_kvadrat(x, y, l, 10);
	glFlush();
}

void main(int argc, char** argv)
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_SINGLE || GLUT_RGB);
	glutInitWindowSize(400, 400);
	glutInitWindowPosition(100, 150);
	glutCreateWindow("");
	glutDisplayFunc(myDisplay);
	myInit();
	glutMainLoop();
}