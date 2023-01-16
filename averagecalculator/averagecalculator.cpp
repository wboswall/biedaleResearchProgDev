/*	Created on: 31 Nov 2016
	Revised Date:
	Project Name: Average Calculator
    Description: Calculates and displays the average number.
	Coded by: WB
*/
#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    //declare variables
    double firstNum=0.0;
    double secondNum=0.0;
    double thirdNum=0.0;
    double sum=0.0;
    double average=0.0;
    //get input
    cout<<"first number"<<endl;
    cin>>firstNum;
    cout<<"second number"<<endl;
    cin>>secondNum;
    cout<<"third number"<<endl;
    cin>>thirdNum;
    //calculate assessed total
    sum=firstNum+secondNum+thirdNum;
    average=sum/3;
    //display annualPropertyTaxTotal
    cout<<"The sum is: "<<sum<<endl;
    system("pause");
	return 0;
}//end of program
