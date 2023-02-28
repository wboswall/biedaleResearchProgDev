/*	Created on: 26 Dec 2016
	Revised Date:
	Project Name: Plates of Things App
    Description: Calculates and the total cost of purchased items.
	Coded by: WB
*/
#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
   double cupPrice=0.0;
   double platePrice=0.0;
   double cupsPurchased=0.0;
   double platesPurchased=0.0;
   double const SALES_TAX_RATE=1.055;
   double subtotal=0.0;
   double total=0.0;
   cout<<"Enter cup price: ";
   cin<<cupPrice;
   cout<<"Enter plate price: ";
   cin<<platePrice;
   cout<<"Enter cups purchased: ";
   cin<<cupsPurchased;
   cout<<"Enter cups purchased: ";
   cin<<cupsPurchased;
   subtotal=(cupPrice*cupsPurchased)+(platesPrice*platesPurchased);
   total=SALES_TAX_RATE*subtotal;
	cout<<"End"<<endl;
    system("pause");
	return 0;
}//end of program
