#include <iostream>
#include <math.h>
using namespace std;

int main()
{
    double radius;
    const double PI=3.14;
    double area=0.0;
    int sliceNum;
    cout<<"Enter the radius of the pizza\n";
    cin>>radius;
    area=PI*pow(radius,2);
    sliceNum=area/14.13;
    cout<<"number of slices ="<<sliceNum<<endl;
    return 0;
}
