# include <windows.h>
# include <math.h>
# include <GL\GL.h>
# include <gl\GLU.h>
# include <gl\glut.h>

void myInit()
{
	glClearColor(1.0, 1.0, 1.0, 0.0);
	glColor3f(0.0, 0.0, 0.0);
	glPointSize(1.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	glOrtho(-4.7, -2.3, -0.3, 1.1, -4.0, 4.0);
}

void Krivaja_Levi(double x1, double y1, double x2,  double y2,int n)
{
	double x3,y3;
	glColor3f(1.0, 0.0, 0.0);
	if (n == 0)
	{
		glBegin(GL_LINE_STRIP);
		glVertex3d(x1, y1, 0.0);
		glVertex3d(x2, y2, 0.0);
		glEnd();
	}
	else
	{
		x3 = (x1 + x2) / 2 - (y2 - y1) / 2;
		y3 = (y1 + y2) / 2 + (x2 - x1) / 2;
		Krivaja_Levi(x1, y1, x3, y3, n - 1);
		Krivaja_Levi(x3, y3, x2, y2, n - 1);
	}
}

void myDisplay()
{
	Krivaja_Levi(-4.0, 0.0, -3.0, 0.0,13);
	glFlush();
}

void main(int argc, char** argv)
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_SINGLE || GLUT_RGB);
	glutInitWindowSize(640, 480);
	glutInitWindowPosition(100, 150);
	glutCreateWindow("");
	glutDisplayFunc(myDisplay);
	myInit();
	glutMainLoop();
}