/*	Created on: 27 Dec 2016
	Revised Date:
	Project Name: A-1 Appliances
    Description: calculates the total. 
	Coded by: WB
*/
#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double begMonthPurchased=0.0;
	double numPurchasedDuringMonth=0.0;
	double numSoldEndOfMonth=0.0;
	double endMonthTotal=0.0;
	cout<<"Enter beginning month purchased: "<<endl;
	cin>>begMonthPurchased;
	cout<<"Enter purchased during month: "<<endl;
	cin>>numPurchasedDuringMonth;
	cout<<"Enter sold end of month: "<<endl;
	cin>>numSoldEndOfMonth;
	endMonthTotal=(begMonthPurchased+numPurchasedDuringMonth)-numSoldEndOfMonth;
	cout<<"End Of Month Total is: "<<endMonthTotal<<endl;
	cout<<"End"<<endl;
    system("pause");
	return 0;
}//end of program
