#include <iostream>

using namespace std;
void getInput(double &num1, double &num2);
void calcSumAndDiff(double num1, double num2, double &numSum, double &numDiff);
void display(double num1, double num2, double numSum, double numDiff);
int main()
{
	double n1, n2, sum, diff;
	getInput(n1, n2);
	calcSumAndDiff(n1, n2, sum, diff);
	display(n1, n2, sum, diff);
    return 0;
}
void getInput(double &num1, double &num2)
{

	cout<<"Enter first number\n";
	cin>>num1;
	cout<<"Enter second number\n";
	cin>>num2;
}
void calcSumAndDiff(double num1, double num2, double &numSum, double &numDiff)
{
	numSum = num1 + num2;
	numDiff = num1 - num2;
}
void display(double num1, double num2, double numSum, double numDiff)
{
	cout<<num1<<" + " <<num2 <<" = "<<numSum<<endl;
	cout<<num1<<" - "<<num2<< "="<<numDiff<<endl;
}
