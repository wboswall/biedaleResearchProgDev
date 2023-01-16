#include <stdio.h>
#include <stdlib.h>

#include "CT.h"
/* run this program using the console pauser or add your own getch, system("pause") or input loop */


void displayHelloWorld();
void calcArea();


int main(int argc, char *argv[]) 
{
	displayHelloWorld();
	calcArea();
	return 0;
}

void displayHelloWorld()
{
	printf("Hello, World!\n");
}

void calcArea(int radius, int area)
{
	printf("Enter radius (i.e. 10): \n");
	
	scanf("%d", &radius);
	area = (int) (3.14159 * radius * radius);
	printf("\n\nArea = %d\n", area);
}