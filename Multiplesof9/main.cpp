#include <iostream>

using namespace std;

int main()
{
    //Create a program that displays the number 0 through 117, of increments of 9.
    for (int number =0; number <=117; number +=9)
	{
		cout<<number<<" ";
		cout<<endl;
	}
	int number1=0;
	while (number1 <=117)
	{
		cout << " "<<number1 <<" ";
		cout<<endl;
		number1 += 9;
	}
    return 0;
}
