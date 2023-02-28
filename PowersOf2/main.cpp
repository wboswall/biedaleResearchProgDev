#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

int main()
{
    double number;
    cout<<"Enter a number smaller than 100\n";
    cin>>number;
    cout<<fixed;
    cout<< setprecision(2);
    for (int i=2; i<=20; i++)
    {
        cout<<number<<" to the " <<i<<"power ="<<pow(number, i)<<endl;
    }
    cin.get();
    return 0;
}
