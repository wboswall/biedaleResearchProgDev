/*	Created on: 24 Dec 2016
	Revised Date:
	Project Name: Colfax Products Commission
    Description: Calculates and displays commission.
	Coded by: WB
*/
#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double sale1=0.0;
    double sale2=0.0;
    double commissionRate=0.0;
    double totalSales=0.0;
    double commission=0.0;
    cout<<"enter sale1: "<<endl;
    cin>>sale1;
    cout<<"enter sale2: "<<endl;
    cin>>sale2;
    cout<<"enter commission rate: "<<endl;
    cin>>commissionRate;
    totalSales=sale1+sale2;
    commission=totalSales*commissionRate;
    cout<<"Commission is: "<<commission<<endl;
    system("pause");
	return 0;
}//end of program
