# include <windows.h>
# include <GL\GL.h>
# include <gl\GLU.h>
# include <gl\glut.h>

GLfloat Points[4][3] = { { 0.0, 0.0, 0.0 }, { 4.0, 0.0, 0.0 }, {4.0, 4.0, 0.0 }, { 0.0, 4.0,0.0 } };
void myInit()
{
	glClearColor(1.0, 1.0, 1.0, 0.0);
	glColor3f(0.0, 0.0, 0.0);
	glPointSize(4.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	glOrtho(-2.0, 5.0, -2.0, 5.0, -4.0, 4.0);
	glMap1f(GL_MAP1_VERTEX_3, 0.0, 1.0, 3, 4, &Points[0][0]);
	glEnable(GL_MAP1_VERTEX_3);
}

void myDisplay()
{
	glClear(GL_COLOR_BUFFER_BIT);
	glColor3f(1.0, 0.0, 0.0);
	glBegin(GL_LINE_LOOP);
	for (GLint i = 0; i <= 100; i++)
	{
		glEvalCoord1f((GLfloat)i/100.0);
	}
	glEnd();
	glColor3f(1.0, 1.0, 0.0);
	glBegin(GL_POINTS);
		glVertex3f(Points[0][0], Points[0][1], Points[0][2]);
	glVertex3f(Points[1][0], Points[1][1], Points[1][2]);
	glVertex3f(Points[2][0], Points[2][1], Points[2][2]);
	glVertex3f(Points[3][0], Points[3][1], Points[3][2]);
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