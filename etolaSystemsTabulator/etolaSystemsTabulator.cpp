/*	Created on: 25 Dec 2016
	Revised Date:
	Project Name: Etola Systems Tabulator
    Description: Calculates and displays inventory.
	Coded by: WB
*/
#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double amountSold=0.0;
	double amountReturned=0.0;
	double begInventory=0.0;
	double endingInventory=0.0;
	cout<<"Enter beginning amount: "<<endl;
	cin>>begInventory;
	cout<<"Enter amount sold: "<<endl;
	cin>>amountSold;
	cout<<"Enter amount returned: "<<endl;
	cin>>amountReturned;
	endingInventory=begInventory+(amountSold-amountReturned);
    system("pause");
	return 0;
}//end of program
