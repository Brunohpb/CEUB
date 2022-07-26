#include <GL/glut.h>
 
void desenhar()
{
        glClear(GL_COLOR_BUFFER_BIT);
       
       
        // Desenha uma casinha composta de um quadrado e um tri�ngulo

	// Altera a cor do desenho para azul
	glColor3f(0.0f, 0.0f, 1.0f);     
	// Desenha a casa
	glBegin(GL_QUADS);
		glVertex2f(-8,-8);
		glVertex2f(8,-8);       
		glVertex2f( 8, 3);       
		glVertex2f( -8, 3);
	glEnd();

	glColor3f(0.0f, 1.0f, 0.0f); // verde   
	glBegin(GL_QUADS);
		glVertex2f(4,-4);
		glVertex2f(7,-4);       
		glVertex2f( 7,-2);       
		glVertex2f( 4, -2);
	glEnd();

	glColor3f(0.0f, 1.0f, 0.0f); // verde  
	glBegin(GL_QUADS);
		glVertex2f(-6,-8);
		glVertex2f(-4,-8);       
		glVertex2f( -4,-5);       
		glVertex2f( -6, -5);
	glEnd(); 
	   
	glColor3f(1.0f, 0.0f, 0.0f); 
	glBegin(GL_TRIANGLES);
		glVertex2f(0, 8);   
		glVertex2f(8, 3);    
		glVertex2f( -8, 3);       
	glEnd();
		
		
        glutSwapBuffers();
}
 
int main(int argc, char** argv)
{
        glutInit(&argc, argv);
        glutInitDisplayMode(GLUT_DOUBLE| GLUT_RGBA);
        glutInitWindowSize(640,640);
        glutCreateWindow("Aula2");
        glutDisplayFunc(desenhar);
        gluOrtho2D(-10,10,-10,10);
        glClearColor(1,1,1,0);
        glutMainLoop();
        return 0;
}
