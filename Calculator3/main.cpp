#include <iostream>

using namespace std;
void getInput(double &num1, double &num2, double &num3, double &num4);
double calcAverage(double num1, double num2, double num3, double num4);
void display(double num1, double num2, double num3, double num4, double numAvg);
int main()
{
    double n1, n2, n3, n4,avg;
    getInput(n1, n2, n3, n4);
    avg=calcAverage(n1, n2, n3, n4);
    display(n1, n2, n3, n4, avg);
    return 0;
}
void getInput(double&num1, double &num2, double&num3, double&num4)
{
	cout<<"Enter first number\n";
	cin>>num1;
	cout<<"Enter second number\n";
	cin>>num2;
	cout<<"Enter third number\n";
	cin>>num3;
	cout<<"enter fourth number\n";
	cin>>num4;
}
double calcAverage(double num1, double num2, double num3, double num4)
{
	return (num1 + num2 + num3 + num4) /4;
}
void display(double num1, double num2, double num3, double num4, double numAvg)
{
	cout<<"Average of "<<num1<<"," <<num2<<","<<num3<<","<<num4<<" is " <<numAvg<<endl;
}
