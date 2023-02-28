#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;
double calcAverage(double n1, double n2, double n3, double n4);
int main()
{
	double num1,num2,num3,num4,avg;
	cout<<"Enter a number with a decimal\n";
	cin>>num1;
	cout<<"Enter another number with a decimal\n";
	cin>>num2;
	cout<<"Enter a third number with a decimal\n";
	cin>>num3;
	cout<<"Enter a fourth number with a decimal\n";
	cin>>num4;
	avg=calcAverage(num1,num2,num3,num4);
	cout<<fixed<<setprecision(2)<<endl;
	cout<<"The average of the four numbers is "<<avg<<endl;
    cin.get();
    return 0;
}
double calcAverage(double n1, double n2, double n3, double n4)
	{
		double quotient;
		quotient=n1+n2+n3+n4;
		return quotient/4;
	}
