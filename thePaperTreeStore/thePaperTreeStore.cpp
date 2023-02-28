#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double lengthFeet=0.0;
    double widthFeet=0.0;
    double ceilingHeightFeet=0.0;
    double numSqFeetRoll=0.0;
    double totalSquareCoverage=0.0;
    cout<<"Enter length in feet "<<endl;
    cin>>lengthFeet;
    cout<<"Enter width in feet "<<endl;
    cin>>widthfeet;
    cout<<"Enter ceilng height in feet"<<endl;
    cin>>ceilingHeightFeet;
    cout<<"Enter number of square feet of roll"<<endl;
    cin>>numSqFeetRoll;
    totalSquareCoverage=(lengthFeet*widthFeet*ceilingheightFeet)/numSqFeetRoll;
    cout<<"Total square feet coverage is: "<<totalSquareCoverage<<endl;
	cout<<"End"<<endl;
    system("pause");
	return 0;
}//end of program
