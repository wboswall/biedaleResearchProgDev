#include <stdio.h>
#include <stdlib.h>
#define TARGET_AGE 88
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	//Program to calculate what year someone will turn a specific age
	
	int year1, year2;
	int calcYear(int year1);
	//ask the user for the birth year
	printf("What year was the subject born? ");
	printf("\nEnter as a 4-digit year (YYYY):  ");
	scanf(" %d", &year1);
	//calculate the future year and display it
	year2=calcYear(year1);
	printf("Someone born in %d will be %d in %d ", year1, TARGET_AGE, year2);
	return 0;
}
/*The funciton to get the future year*/
int calcYear(int year1)
{
	return(year1+TARGET_AGE);
}
