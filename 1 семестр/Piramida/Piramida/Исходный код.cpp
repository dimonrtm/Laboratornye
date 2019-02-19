# include <windows.h>
# include <GL\GL.h>
# include <gl\GLU.h>
# include <gl\glut.h>

void myInit()
{
	glClearColor(1.0, 1.0, 1.0, 0.0);
	glColor3f(0.0, 0.0, 0.0);
	glPointSize(4.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	glOrtho(-8,8,-8,8,-8,8);
}
void myDisplay()
{
	glClear(GL_COLOR_BUFFER_BIT);
	glColor3f(1.0, 0.0, 0.0);
	glBegin(GL_TRIANGLES);
	glColor3f(0.0, 1.0, 0.0);
	glVertex3f(-2.5, -3.8, 4.0);
	glVertex3f(0.0, 4.0, -2.8);
	glVertex3f(1.8, -3.5, 2.1);
	glColor3f(0.0, 0.0, 1.0);
	glVertex3f(0.0, 4.0, -2.8);
	glVertex3f(1.8, -3.5, 2.1);
	glVertex3f(4.0, 0.0, 2.8);
	glColor3f(1.0, 0.0, 0.0);
	glVertex3f(0.0, 0.0, 0.0);
	glVertex3f(-2.5, -3.8, 4.0);
	glVertex3f(0.0, 4.0, -2.8);
	glColor3f(1.0, 1.0, 0.0);
	glVertex3f(0.0, 0.0, 0.0);
	glVertex3f(0.0, 4.0, -2.8);
	glVertex3f(4.0, 0.0, 2.8);
	
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