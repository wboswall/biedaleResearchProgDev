/*	Created on: 31 Nov 2016
	Revised Date:
	Project Name: Property Tax Calculator V 0.1
    Description: Calculates and displays the property tax total.
	Coded by: WB
*/
#include <iostream>
using namespace std;
int main()
{
    //declare variables
    double assessedValue=0.0;
    double taxRate=0.0;
    double assessedTotal=0.0;
    double annualPropertyTaxTotal=0.0;
    //get input
    cout<<"assessed value: "<<endl;
    cin>>assessedValue;
    cout<<"tax rate: "<<endl;
    cin>>taxRate;
    //calculate assessed total
    assessedTotal=assessedValue/100;
    annualPropertyTaxTotal=assessedTotal*100;
    //display annualPropertyTaxTotal
    cout<<"Annual Property Tax Total is: $"<<annualPropertyTaxTotal<<endl;
    system("pause");
	return 0;
}//end of program
