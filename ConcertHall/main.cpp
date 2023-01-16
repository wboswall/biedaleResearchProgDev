#include <iostream>

using namespace std;

int main()
{
    int orchestra, main, balcony;
    double total=0.0;
    cout<<"Enter the number of Orchestra seats\n";
    cin>>orchestra;
    cout<<"Enter the number of main floor seats\n";
    cin>>main;
    cout<<"Enter the number of balcony seats\n";
    cin>>balcony;
    total=static_cast<double>(orchestra*25+main*30+balcony*15);
    cout<<"The total revenue="<<total<<endl;
    return 0;
}
