/*	Created on: 27 Dec 2016
	Revised Date:
	Project Name: Aiden's weekly pay calculator
    Description: calculates the new weekly pay. 
	Coded by: WB
*/
#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
   
    double raisePercentage=0.0;
	double currentWeeklyPay=0.0;
	double newWeeklyPay=0.0;
	cout<<"Enter raisePercentage: "<<endl;
	cin>>raisePercentage;
	cout<<"Enter current weekly pay: "<<endl;
	cin>>currentWeeklyPay;
	newWeeklyPay=(currentWeeklyPay*raisePercentage)+currentWeeklyPay;
	cout<<"New Weekly Pay is: "<<newWeeklyPay<<endl;
	cout<<"End"<<endl;
    system("pause");
	return 0;
}//end of program
