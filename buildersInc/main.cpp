#include <iostream>

using namespace std;

int main()
{
    double diameter, unitPrice, cir, totalPrice;
    const double PI=3.1416;
    cout<<"What is the diameter?\n";
    cin>>diameter;
    cir=2*PI*diameter;
    cout<<"What is the unit price of railing material per food?\n";
    cin>>unitPrice;
    totalPrice=cir*unitPrice;
    cout<<"The total price of the railing the swimming pool is " <<totalPrice<<endl;
    return 0;
}
