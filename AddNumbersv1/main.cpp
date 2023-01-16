#include <iostream>
#include <cmath>
using namespace std;

void inputNumbers (double &n1, double &n2);
double add (double n1, double n2);
void displayResult(double n1, double n2, double a);

int main()
{
    double num1, num2, answer;
    inputNumbers (num1, num2);
    answer= add(num1, num2);
    displayResult (num1, num2, answer);
    cin.get();
    return 0;
}
void inputNumbers(double &n1, double &n2)
{
	cout<<"Enter the first number \n";
	cin>>n1;
	cout<<"Enter the second number\n";
	cin>>n2;
}
double add(double n1, double n2)
{
	return pow(n1,3)+sqrt(n2);
}
void displayResult(double n1, double n2, double a)
{
	cout<<n1<<" cubed plus square root of "<<n2<<" is " << a <<endl;
}
