#include <iostream>

using namespace std;
void getInput(double &num1, double &num2);
    double calcQuotient(double num1, double num2);
    void display(double num1, double num2, double quotient);
int main()
{
    double n1, n2, answer;
    getInput(n1,n2);
    answer=calcQuotient(n1, n2);
    display(n1,n2,answer);
    return 0;
}
void getInput(double &num1, double &num2)
{

	cout<<"Enter first number\n";
	cin>>num1;
	cout<<"Enter second number\n";
	cin>>num2;
}
double calcQuotient(double num1, double num2)
{
	return num1/num2;
}
void display (double num1, double num2, double quotient)
{
	cout<<num1<<"divide by " <<num2<<" is= "<<quotient<<endl;
}
