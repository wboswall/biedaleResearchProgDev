#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
    char anotherSale=' ';
    int salesAmount=0;
    int totalSales=0;
    cout<<"Do you want to enter a sales amount (Y or N)? ";
    cin>>anotherSale;
    do
	{
		cout<<"Enter the sales amount: ";
		cin>>salesAmount;
		totalSales +=salesAmount;
		cout<<"Do you want to enter a sales amount (Y or N)? ";
		cin>>anotherSale;
    }
    while(toupper(anotherSale)=='Y');
    cout<<fixed <<setprecision(0);
    cout<<"Total sales: $"<<totalSales<<endl;
    return 0;
}
