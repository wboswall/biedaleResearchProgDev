/*	Created on: 25 Nov 2016
	Revised Date:
	Project Name: Pay Raise
	Description: Calculates and displays the new weekly pay.
	Coded by: WB
*/
#include <iostream>
using namespace std;
int main()
{
    //declare variables
    double currentWeeklyPay=0.0;
    double raisePercentage=0.0;
    double payRaise=0.0;
    double newWeeklyPay=0.0;
    //get input
    cout<<"Enter current weekly pay: "<<endl;cin>>currentWeeklyPay;
    cout<<"Enter raise percentage: "<<endl; cin>>raisePercentage;
    //calculate newWeeklyPay
    payRaise=currentWeeklyPay*raisePercentage;
    cout<<"Pay Raise: $"<<payRaise<<endl;
    newWeeklyPay=currentWeeklyPay+payRaise;
    cout<<"New weekly pay: $"<<newWeeklyPay<<endl;
	system("pause");
	return 0;
}//end of program
