/*	Created on: 21 Nov 2016
	Revised Date:
	Project Name:Treyson Mobley Tip App Version 0.0
	Description: Calculates and displays the tip.
	Coded by: WB
*/
#include <iostream>
using namespace std;
int main()
{
	double totalBill=0.0;
	double liquor=0.0;
	double tipPercent=0.0;
	double totalNoLiquor=0.0;
	double tip=0.0;
	cout<<"Enter the total bill: "<<endl;
	cin>>totalBill;
	cout<<"Enter liquor charge:"<<endl;
	cin>>liquor;
	cout<<"Enter tip percentage (in decimal form only): "<<endl;
	cin>>tipPercent;
	//calculate
	totalNoLiquor=totalBill-liquor;
	tip=totalNoLiquor*tipPercent;
	//display
	cout<<"TotalNoLiquor:  "<<totalNoLiquor<<endl;
	cout<<"Tip:$ "<<tip<<endl;
	system("pause");
	return 0;
}//end of program
