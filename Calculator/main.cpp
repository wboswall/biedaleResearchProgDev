#include <iostream>

using namespace std;

int main()
{
    double num1, num2;
    double product, quotient, sum, difference;
    cout<<"Please enter first number\n";
    cin>>num1;
    cout<<"Please enter second number\n";
    cin>>num2;
    sum=num1+num2;
    product =num1*num2;
    if(num1>num2)
	{

		difference=num1-num2;
		quotient=num1/num2;
	}
	else{
		difference=num2-num1;
		quotient=num2/num1;
	}
	cout<<"The result of sum of the numbers is "<<sum<<endl;
	cout<<"The result of product of the numbers is "<<product<<endl;
	cout<<"The result of difference of the numbers is: "<<difference<<endl;
	cout<<"The result of quotient of the numbers is " <<quotient<<endl;
    return 0;
}
