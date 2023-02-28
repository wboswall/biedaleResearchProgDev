#include <iostream>

using namespace std;

int main()
{
    double jimSales, marySales, highSales, lowSales;
    cout<<"Please enter Mary's sales amount\n";
    cin>>marySales;
    cout<<"Please enter Jim's sales amount\n";
    cin>>jimSales;
    if(marySales>jimSales)
	{
		highSales=marySales;
		lowSales=jimSales;
		cout<<"Mary's sales amount is highest with $"<<highSales<<endl;
		cout<<"Jim's sales amount is lowest with $"<<lowSales<<endl;
	}
	else
	{
		highSales=jimSales;
		lowSales=marySales;
		cout<<"Jim's sales amount is highest with $"<<highSales<<endl;
		cout<<"Mary's sales amount is lowest with $"<<lowSales<<endl;
	}
    return 0;
}
