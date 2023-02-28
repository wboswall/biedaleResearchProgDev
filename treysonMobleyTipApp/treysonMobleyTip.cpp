/*	Created on: 24 Dec 2016
	Revised Date:
	Project Name: Treyson Mobley Tip v.03
    Description: Calculates and displays the tip.
	Coded by: WB
*/
#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double totalBill=0.0;
    double liquorCharge=0.0;
    double tipPercentage=0.0;
    double tip=0.0;
    cout<<"enter the total bill: "<<endl;
    cin>>totalBill;
    cout<<"enter the liquor charge: "<<endl;
    cin>>liquorCharge;
    cout<<"enter the tip percentage (in decimal form only)"<<endl;
    cin>>tipPercentage;
    tip=(liquorCharge-totalBill)*tipPercentage;
    cout<<"tip percentage is: "<<tip<<endl;
    
    system("pause");
	return 0;
}//end of program
