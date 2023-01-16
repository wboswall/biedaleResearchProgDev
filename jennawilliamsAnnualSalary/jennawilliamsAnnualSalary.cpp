#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double annualSalary=0.0;
    double numPayPeriods=0.0;
    double grossPay=0.0;
    cout<<"Enter annual salary: "<<endl;
    cin>>annualSalary;
    cout<<"enter number of pay periods: "<<endl;
    cin>>numPayPeriods;
    grossPay=annualSalary/numPayPeriods;
    cout<<"Gross Pay for each pay period is: "<<grossPay<<endl;
	cout<<"End"<<endl;
    system("pause");
	return 0;
}//end of program
