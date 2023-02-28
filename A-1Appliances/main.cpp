#include <iostream>

using namespace std;

int main()
{
    double inStock=0.0;
    double purchase=0.0;
    double sold=0.0;
    double endStock=0.0;
    cout<<"Enter the beginning inventory\n";
    cin>>inStock;
    cout<<"Enter the purchase amount\n";
    cin>>purchase;
    cout<<"Enter the sold amount\n";
    cin>>sold;
    endStock=inStock+purchase-sold;
    cout<<"the end stock is" <<endStock<<endl;
    return 0;
}
