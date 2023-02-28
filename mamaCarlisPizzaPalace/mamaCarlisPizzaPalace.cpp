#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double numSlices=0.0;
    double radius=0.0;
    const double AREA_SLICE=14.13;
    const double PI=3.14;
    double area=0.0;
    cout<<"Enter radius: "<<endl;
    cin>>radius;
    area=PI*pow(radius,2);
    numSlices=area/AREA_SLICE;
    cout<<"The number of slices are: "<<numSlices<<endl;
    cout<<"End"<<endl;	
    system("pause");
	return 0;
}//end of program
