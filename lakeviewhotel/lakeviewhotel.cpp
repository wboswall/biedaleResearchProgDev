/*	Created on: 25 Nov 2016
	Revised Date:
	Project Name: Lakeview Hotel
	Description: Calculates and displays the total bill.
	Coded by: WB
*/
#include <iostream>
using namespace std;
int main()
{
    //declare variables
    double numNights=0.0;
    double perNightRate=0.0;
    double roomServiceCharge=0.0;
    double telephoneCharge=0.0;
    double totalBill=0.0;
    double roomCharge=0.0;
    //get input
    cout<<"Enter Number of Nights: "<<endl;cin>>numNights;
    cout<<"Enter per-night rate:$ "<<endl; cin>>perNightRate;
    cout<<"Enter room service charge:$ "<<endl;cin>>roomServiceCharge;
    cout<<"Enter telephone charge: $"<<endl; cin>>telephoneCharge;
    //calculate totalBill
    roomCharge=numNights*perNightRate;
    cout<<"Amount of room charge :$"<<roomCharge<<endl;
    totalBill=roomCharge+roomServiceCharge+telephoneCharge;
    cout<<"Total bill is :$"<<totalBill<<endl;
    system("pause");
	return 0;
}//end of program
