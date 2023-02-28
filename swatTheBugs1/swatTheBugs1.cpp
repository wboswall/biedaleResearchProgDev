#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double originalPrice=0.0;
    const double DISCOUNT_RATE=1.10;
    double newPrice=0.0;
    cout<<"Enter origional price: "<<endl;
    cin>>originalPrice;
    newPrice=originalPrice+(originalPrice*DISCOUNT_RATE);
    cout<<"New Price is: "<<endl;
    cout<<"End"<<endl;	
    system("pause");
	return 0;
}//end of program
