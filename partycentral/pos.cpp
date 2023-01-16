/*	Created on: 21 Nov 2016
	Revised Date:
	Project Name: Party Central
	Description: Calculates and displays the total owed.
	Coded by: WB
*/
#include <iostream>
using namespace std;
int main()
{
	//declare variables and named constant
	int cupsPurchased=0;
	int platesPurchased=0;
	double cupPrice=0.0;
	double platePrice=0.0;
	double totalCupCost=0.0;
	double totalPlateCost=0.0;
	double subtotal=0.0;
	double totalCost=0.0;
	const double TAX_RATE=.055;
	//enter input items
	cout<<"Cup price: ";
	cin>>cupPrice;
	cout<<"Plate price: ";
	cin>>platePrice;
	cout<<"Cups purchased: ";
	cin>>cupsPurchased;
	cout<<"Plates purchased: ";
	cin>>platesPurchased;
	//calculate total cup cost, total plate
	//cost, the subtotal, and the total cost
	totalCupCost=cupsPurchased*cupPrice;
	totalPlateCost=platesPurchased*platePrice;
	subtotal=totalCupCost+totalPlateCost;
	totalCost=(subtotal*TAX_RATE)+subtotal;
	cout<<"total cup cost: "<<totalCupCost<<endl;
	cout<<"total plate cost: "<<totalPlateCost<<endl;
	cout<<"subtotal : "<<subtotal<<endl;
	//display total cost
	cout<<"total cost: $ "<<totalCost<<endl;
	system("pause");
	return 0;
}//end of program
