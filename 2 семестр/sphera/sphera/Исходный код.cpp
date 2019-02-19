# include <windows.h>
# include <cmath>
# include <GL\GL.h>
# include <gl\GLU.h>
# include <gl\glut.h>
# include <ctime>
# include <iostream>
using namespace std;

float x1 = -240;
float x2 = 240;
float y3 = -240;
float y2 = 240;
float z1 = -240;
float z2 = 240;
float sfera1 = 10;
float sfera2 = 140;
float sfera2x =240;
float sfera2y =240;
float sfera3 = 5;
float sfera3x = 50;
float sfera3y = 50;
float sfera4 = 3;
float sfera4x = 100;
float sfera4y = 100;
float sfera5 = 15;
float sfera5x = -60;
float sfera5y = -60;
float xsf = -7;
float zsf = -10;


void myInit()
{
	glClearColor(0.0, 0.0, 0.0, 0.0);
	glColor3f(0.0, 0.0, 0.0);
	glPointSize(4.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	glOrtho(x1, x2, y3, y2, z1, z2);
}

void myDisplay()
{
	
	float arr1[3] = { 1.0, 0.0, 0.0 };
	float arr2[3] = { 0.0, 1.0, 0.0 };
	float arr3[4] = { 10.0, 10.0, 10.0, 0.0 };
	float arr4[4] = { -20.0, -20.0, -20.0, 0.0 };
	float arr5[3] = { 0.3, 1.0, 0.0 };
	float arr6[4] = { -20.0, 20.0, -20.0, 0.0 };
	float arr7[4] = { 20.0, 20.0, 20.0 ,0.0};
	float arr8[3] = { 1.0, 1.0, 0.0 };
	float arr9[4] = { 20.0, -20.0, 20.0, 0.0 };
	float arr10[3] = { 1.0, 1.0, 1.0 };
	float arr11[4] = { 0.0, 0.0, -240 };
	float arr12[3] = { -7.0, 0.0, -10 };
	float arr13[3] = { 0.0, 0.0, 1.0 };
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	glEnable(GL_DEPTH_TEST);
	glMaterialfv(GL_FRONT, GL_AMBIENT_AND_DIFFUSE,arr1);
	glMaterialfv(GL_FRONT, GL_SPECULAR, arr2);
	glMaterialf(GL_FRONT, GL_SHININESS, 10.0);
	glLightModelfv(GL_LIGHT_MODEL_AMBIENT, arr2);
	glLightfv(GL_LIGHT0, GL_POSITION, arr3);
	glLightfv(GL_LIGHT0, GL_DIFFUSE, arr2);
	glLightfv(GL_LIGHT1, GL_POSITION, arr4);
	glLightfv(GL_LIGHT1, GL_DIFFUSE, arr1);
	glLightfv(GL_LIGHT2, GL_POSITION, arr6);
	glLightfv(GL_LIGHT2, GL_DIFFUSE, arr5);
	glLightfv(GL_LIGHT3, GL_POSITION, arr7);
	glLightfv(GL_LIGHT3, GL_DIFFUSE, arr8);
	glLightfv(GL_LIGHT4, GL_POSITION, arr9);
	glLightfv(GL_LIGHT4, GL_DIFFUSE, arr8);
	glLightfv(GL_LIGHT5, GL_POSITION, arr11);
	glLightfv(GL_LIGHT5, GL_SPOT_DIRECTION, arr12);
	glLightf(GL_LIGHT5, GL_SPOT_EXPONENT, 400);
	glLightf(GL_LIGHT5, GL_SPOT_CUTOFF, 5);
	glLightfv(GL_LIGHT5, GL_DIFFUSE, arr13);
	glEnable(GL_LIGHT0);
	glEnable(GL_LIGHT1);
	glEnable(GL_LIGHT2);
	glEnable(GL_LIGHT3); 
	glEnable(GL_LIGHT4);
	glEnable(GL_LIGHT5);
	glEnable(GL_LIGHTING);
	glutSolidSphere(sfera1, 26, 26);
	glColor3f(1.0, 1.0, 0.0);
	glPushMatrix();
	glTranslatef(sfera2x, sfera2y, 0);
	glMaterialfv(GL_FRONT, GL_AMBIENT_AND_DIFFUSE, arr1);
	glutSolidSphere(sfera2, 26, 26);
	glPopMatrix();
	glPushMatrix();
	glTranslatef(sfera3x, sfera3y, 0);
	glutSolidSphere(sfera3, 26, 26);
	glPopMatrix();
	glPushMatrix();
	glTranslatef(sfera4x, sfera4y, 0);
	glutSolidSphere(sfera4, 26, 26);
	glPopMatrix();
	glPushMatrix();
	glTranslatef(sfera5x, sfera5y, 0);
	glutSolidSphere(sfera5, 26, 26);
	glPopMatrix();
	glDisable(GL_LIGHT0);
	glDisable(GL_LIGHT1);
	glDisable(GL_LIGHT2);
	glDisable(GL_LIGHT3);
	glDisable(GL_LIGHT4);
	glDisable(GL_LIGHT5);
	glDisable(GL_LIGHTING);
	glDisable(GL_DEPTH_TEST);
	glutSwapBuffers();
}

void timf(int value)
{
	if (sfera1<140)
	{
		sfera1++;
		sfera2++;
		sfera3++;
		sfera4++;
		sfera5++;
		sfera2x+=4;
		sfera2y+=4;
		sfera4x += 3;
		sfera4y += 3;
		sfera3x+=2;
		sfera3y+=2;
		sfera5x -= 2;
		sfera5y -= 2;
		xsf--;
		zsf--;
	}
	if (sfera1 == 140)
	{
		 sfera1 = 10;
		 sfera2 = 140;
		 sfera2x = 240;
		 sfera2y = 240;
		 sfera3 = 5;
		 sfera3x = 50;
		 sfera3y = 50;
		 sfera4 = 3;
		 sfera4x = 100;
		 sfera4y = 100;
		 sfera5 = 15;
		 sfera5x = -60;
		 sfera5y = -60;
		 xsf = -7;
		 zsf = -10;
	}
	glutPostRedisplay();
	glutTimerFunc(70, timf, 0);
}


void main(int argc, char** argv)
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB | GLUT_DEPTH);
	glutInitWindowSize(640, 640);
	glutInitWindowPosition(100, 150);
	glutCreateWindow("");
	glutDisplayFunc(myDisplay);
	glutTimerFunc(70, timf, 0);
	myInit();
	glutMainLoop();
}
