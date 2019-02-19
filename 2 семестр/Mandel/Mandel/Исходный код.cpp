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
	glOrtho(-2.0, 2.0, -2.0, 2.0, -1.41,1.41 );
}

void myDisplay()
{
	double Rz, Imz, temp, z;
	int it = 0, item = 1;
	glBegin(GL_POINTS);
	for (double b = -2.0; b <= 2.0; b = b + 0.002)
	{
		for (double a = -2.0; a <= 2.0; a = a + 0.002)
		{
			it = 0;
			Rz = a;
			Imz = b;
			z = pow(Rz, 2) + pow(Imz, 2);
			while (z < 8 && it < 100)
			{

				temp = pow(Rz, 2) - pow(Imz, 2) + a;
				Imz = 2 * Rz*Imz + b;
				Rz = temp;
				z = pow(Rz, 2) + pow(Imz, 2);
				it++;
			}
			if (it == 100)
			{
				glColor3f(0.0, 0.0, 0.0);
				glVertex3f(a, b, 0);
			}
			else
			{
				item = it % 8;
				switch (item)
				{
				case 0: glColor3f(0.0, 1.0, 1.0); glVertex3d(a, b, 0); break;
				case 1: glColor3f(0.0, 0.0, 1.0); glVertex3d(a, b, 0); break;
				case 2: glColor3f(0.0, 1.0, 0.0); glVertex3d(a, b, 0); break;
				case 3: glColor3f(1.0, 1.0, 0.0);  glVertex3d(a, b, 0); break;
				case 4:glColor3f(1.0, 1.0, 1.0); glVertex3d(a, b, 0); break;
				case 5:glColor3f(1.0, 0.0, 0.0); glVertex3d(a, b, 0); break;
				case 6:glColor3f(1.0, 0.0, 1.0);  glVertex3d(a, b, 0); break;
				case 7:	glColor3f(1.0, 1.0, 0.0); glVertex3d(a, b, 0); break;
				}
			}
			
		}
	}
	glEnd();
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