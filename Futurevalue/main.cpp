#include <iostream>
#include <ctime>
#include <cmath>
using namespace std;

int main()
{
    double rate, future, present, term, timeDiv;
    cout <<"Enter the value for future: ";
    cin>>future;
    cout<<"Enter the value for present: ";
    cin>>present;
    cout<<"Enter the given term value: ";
    cin>>term;
    timeDiv=future/present;
    rate=pow(timeDiv, 1-term)-1;
    cout<<"The rate is: "<<rate <<endl;
    cin.get();
    return 0;
}
