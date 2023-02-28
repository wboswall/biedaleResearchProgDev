#include <iostream>

using namespace std;

int main()
{
    double price1, price2, totalAmount;
    cout<<"Please enter the price of the first item \n";
    cin>>price1;
    cout<<"Please enter the price of the second item\n";
    cin>>price2;
    if(price1>=price2)
	{

		price2=price2/2;
	}
	else
	{

		price1=price1/2;
	}
	totalAmount=price1+price2;
	cout<<"You total amount is $"<<totalAmount<<endl;
    return 0;
}
