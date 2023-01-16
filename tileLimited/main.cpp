#include <iostream>

using namespace std;

int main()
{
    double length, width, area, totalPrice, unitPrice;
    cout<<"what is the length of your bathroom?\n";
    cin>>length;
    cout<<"what is the width of your bathroom?\n";
    cin>>width;
    cout<<"what is the unit price of selected tile?\n";
    cin>>unitPrice;
    area=length*width;
    totalPrice=area*unitPrice;
    cout<<"Your total Price is $"<<totalPrice<<endl;

    return 0;
}
