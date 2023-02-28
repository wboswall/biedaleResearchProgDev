/*	Created on: 26 Dec 2016
	Revised Date:
	Project Name: numbers
    Description: Calculates the sum.
	Coded by: WB
*/
#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
   
    double num1=0.0;
	double num2=0.0;
	double num3=0.0;
	double sum=0.0;
	double average=0.0;
	cout<<"enter number"<<endl;
	cin>>num1;
	cout<<"enter number2"<<endl;
	cin>>num2;
	cout<<"enter number3"<<endl;
	cin>>num3;
	sum=num1+num2+num3;
	average=sum/3;
	cout<<"sum is: "<<sum<<endl;
	cout<<"average is: "<<average<<endl;
	cout<<"End"<<endl;
    system("pause");
	return 0;
}//end of program
