/*	Created on: 25 Nov 2016
	Revised Date:
	Project Name: Gas Milage
	Description: Calculates and displays the miles per gallon.
	Coded by: WB
*/
#include <iostream>
using namespace std;
int main()
{
	//declare variables and named constant
	double gallonsUsed=0.0;
	double milesDriven=0.0;
	double milesPerGallon=0.0;
	//enter input items
	cout<<"Enter Miles Driven: ";cin>>milesDriven;
	cout<<"Enter Gallons used: ";cin>>gallonsUsed;	
	//calculate milesPerGallon by dividing milesDriven by gallonsUsed
	milesPerGallon=milesDriven/gallonsUsed;	
	//display milesPerGallon
	cout<<"Miles per gallon is: "<<milesPerGallon<<endl;	
	system("pause");
	return 0;
}//end of program
