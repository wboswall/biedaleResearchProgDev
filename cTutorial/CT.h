#include <stdio.h>
#include <stdlib.h>

void displayHelloWorld();
void calcArea();
void displayInfo();
void displayEnd();
void displayHelloWorld(){
	printf("Hello, World!\n");
}

void calcArea(int radius, int area){
	printf("Enter radius (i.e. 10): \n");
	
	scanf("%d", &radius);
	area = (int) (3.14159 * radius * radius);
	printf("\n\nArea = %d\n", area);
}
void displayInfo(){
	double height = 0;
	char name[] = " ";
	int age = 0;
	char address[] = " ";
	char phone[] = " ";
	print ("Display Information\n");
	print("Enter your height in decimal form only\n");
	scanf("%lf", &height);
	print("Enter your first name only\n");
	scanf("%s", &name);
	print("Enter your age in decimal form only\n");
	scanf("%d", &age);
	print("Enter your address including postal code\n");
	scanf("%s", &address);
	print("Enter your phone in 10 digit format\n");
	scanf("%s", &phone)
	
	print("Your height is %lf:", height, "\n");
	print("Your name is %s:", name, "\n");
	print("Your age is %d:", age, "\n");
	print("Your height is %s:", address, "\n");
	print("Your height is %s:", phone, "\n");
}
void displayEnd(){
	char message[] = "Thank you for running C Tutorial 0.0.0.2, End of Program.  Program Terminating....";
	print("%s", message);
}
// single line comment example
/*
 *Fancy multi line
 *comment example
 */
 /*
	original multi line 
	example
 */