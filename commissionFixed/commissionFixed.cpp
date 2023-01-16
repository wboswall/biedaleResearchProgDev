/*	Created on: 21 Nov 2016
	Revised Date:
	Project Name:Calculates the displays the commission version 0.0
	Description: Calculates and displays the commission.
	Coded by: WB
*/
#include <iostream>
using namespace std;
int main()
{
	//declare the variables
	double sale1=0.0;
	double sale2=0.0;
	double commissionRate=0.1;
	double totalSales=0.0;
	double commission=0.0;
	//enter input items
	cout<<"First sale? ";
	cin>>sale1;
	cout<<"Second sale? ";
	cin>>sale2;
	//calcuate total sales and commission
	totalSales=sale1+sale2;
	commission=totalSales*commissionRate;
	//display the commission
	cout<<"Commission: $"<<commission<<endl;
	system("pause");
	return 0;
}//end of program
