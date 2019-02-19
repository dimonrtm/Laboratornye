#include <gl/glut.h>
#include <gl/GL.h>
#include <gl/GLU.h>

void draw_TRIANGLES(GLint, GLint);


void display(void)
{
	glClear(GL_COLOR_BUFFER_BIT);
	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();
	glLineWidth(3);
	glColor3f(1.0, 0.0, 0.0);
	glColor3f(1.0, 1.0, 0.0);
	glPushMatrix();
	glTranslatef(-10.0, 120.0, 0.0);
	draw_TRIANGLES(0, 0);
	glPopMatrix();
	glColor3f(1.0, 0.0, 0.0);
	draw_TRIANGLES(0, 0);
	
	
	glEnable(GL_LINE_STIPPLE);
	glLineStipple(1, 0xF0F0);
	glLoadIdentity();
	glTranslatef(-20.0, 0.0, 0.0);
	glColor3f(0.0, 0.0, 1.0);
	glPushMatrix();
	glScalef(-2.0, 0.5, 1.0);
	draw_TRIANGLES(0, 0);
	glPopMatrix();
	glColor3f(1.0, 0.0, 0.0);
	draw_TRIANGLES(0, 0);

	glLineStipple(1, 0xF00F);
	glLoadIdentity();
	glScalef(1.5, 0.5, 1.0);
	glColor3f(1.0, 0.0, 1.0);
	glPushMatrix();
	glRotatef(45.0, 0.0, 0.0, 1.0);
	draw_TRIANGLES(0, 0);
	glPopMatrix();
	glColor3f(1.0, 0.0, 0.0);
	draw_TRIANGLES(0, 0);

	glLineStipple(1, 0x8888);
	glLoadIdentity();
	glRotatef(90.0, 0.0, 0.0, 1.0);
	glColor3f(0.0, 1.0, 0.0);
	glPushMatrix();
	glRotatef(180.0, 0.0, 0.0, 1.0);
	draw_TRIANGLES(0, 0);
	glPopMatrix();
	glColor3f(1.0, 0.0, 0.0);
	draw_TRIANGLES(0, 0);

	glDisable(GL_LINE_STIPPLE);
	glFlush();
}
void init(void)
{
	glClearColor(1.0, 1.0, 1.0, 1.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluOrtho2D(-170.0, 150.0,-200.0,480.0);
}

int main(int argc, char** argv)
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
	glutInitWindowSize(640, 480);
	glutInitWindowPosition(100, 100);
	glutCreateWindow("Hello");
	init();
	glutDisplayFunc(display);
	glutMainLoop();
	return 0;
}
void draw_TRIANGLES(GLint xn, GLint yn)
{
	GLint xd, yd;
	xd = yd = 4;
	glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);
	glBegin(GL_TRIANGLES);
	glVertex2i(-20 * xd + xn, 0 * yd + yn);
	glVertex2i(20 * xd + xn, 0 * yd + yn);
	glVertex2i(0 * xd + xn, 40 * yd + yn);
	glEnd();
}