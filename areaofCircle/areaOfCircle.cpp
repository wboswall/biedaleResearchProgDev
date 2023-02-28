/*	Created on: 26 Dec 2016
	Revised Date:
	Project Name: area of circle
    Description: calculates the area of circle. 
	Coded by: WB
*/
#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
   
    double const PI=3.14;
	double area=0.0;
	double radius=0.0;
	double result=0.0;
	cout<<"Enter the radius: "<<endl;
	cin>>radius;
	result=radius*radius;
	area=result*PI
	cout<<"Area is: "<<area;
	cout<<"End"<<endl;
    system("pause");
	return 0;
}//end of program
