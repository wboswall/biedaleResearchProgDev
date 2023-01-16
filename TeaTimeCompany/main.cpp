#include <iostream>

using namespace std;

int main()
{
    double teaOrdered, pricePerPound, totalAmount;
    char shipping;
    cout<<"Please enter the number of pounds of tea ordered\n";
    cin>>teaOrdered;
    cout<<"Please enter the price per pound of tea\n";
    cin>>pricePerPound;
    cout<<"Does the order needs to be shipped? (Y/N)\n";
    cin>> shipping;
    totalAmount=teaOrdered*pricePerPound;
    if(toupper(shipping)=='Y')
	{
		totalAmount +=15;
	}
	cout<<"You total amount is $"<<totalAmount<<endl;
    return 0;
}
