/*	Created on: 22 Dec 2016
	Revised Date:
	Project Name: Quotient Calculator
    Description: Calculates and displays the quotient.
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
    double quotient=0.0;
    cout<<"first number: ";cin>>firstNum;
    cout<<"second number: ";cin>>secondNum;
    quotient=firstNum/secondNum;
    cout<<"quotient is: "<<quotient<<endl;
    system("pause");
	return 0;
}//end of program
