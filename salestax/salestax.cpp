/*	Created on: 23 Dec 2016
	Revised Date:
	Project Name: Sales Tax
    Description: Calculates the sales tax
	Coded by: WB
*/
#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    //declare variables
    double purchaseAmount=0.0;
    double salesTax=0.0;
    double salesTaxRate=0.0;
    cout<<"Enter purchase amount: "<<endl;
    cin>>purchaseAmount;
    cout<<"Enter sales tax rate: "<<endl;
    cin>>salesTaxRate;
    salesTax=purchaseAmount*salesTaxRate;
    cout<<"Total Amount: "<<salesTax<<endl;
    system("pause");
	return 0;
}//end of program
