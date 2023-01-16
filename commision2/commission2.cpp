/*	Created on: 27 Dec 2016
	Revised Date:
	Project Name: commission 2
    Description: calculates the new commission. 
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
    cout<<"Enter sale1: "<<endl;
	cin>>sale1;
	cout<<"Enter sale2: "<<endl;
	cin>>sale2;
	cout<<"Commission Rate is (decimal format only): "<<endl;
	cin>>commissionRate;
	totalSales=sale1+sale2;
	commission=totalSales*commisisonRate;
	cout<<"Total Sales: "<<totalSales;
	cout<<"Commission is: "<<commission;
	cout<<"End"<<endl;
    system("pause");
	return 0;
}//end of program
