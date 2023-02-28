/*	Created on: 25 Dec 2016
	Revised Date:
	Project Name: Gee Bees Clothiers Discount App
    Description: Calculates and the discount.
	Coded by: WB
*/
#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double originalPrice=0.0;
	double discountRate=0.0;
	double salePrice=0.0;
	cout<<"Enter original price: "<<endl;
	cin>>originalPrice;
	cout<<"Enter discount rate: "<<endl;
	cin>>discountRate;
	salePrice=originalPrice+(discountRate*originalPrice);
	cout<<"Sale Price is: "<<salePrice<<endl;
	cout<<"Original Price is: "<<originalPrice;
	cout<<"End"<<endl;
    system("pause");
	return 0;
}//end of program
