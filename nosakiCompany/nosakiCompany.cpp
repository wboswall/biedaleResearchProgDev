#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double hoursWorked=0.0;
    double payRate=0.0;
    double rateFWT=0.0;
    double rateFICA=0.0;
    double stateTaxRate=0.0;
    double netPay=0.0;
    double subTotal=0.0;
    cout<<"Enter hours worked"<<endl;
    cin>>hoursWorked;
    cout<<"Enter payRate"<<endl;
    cin>>payRate;
    cout<<"Enter FWT rate"<<endl;
    cin>>rateFWT;
    cout<<"Enter FICA rate"<<endl;
    cin>>rateFICA;
    subTotal=(hoursWorked*payRate);
    netPay=subTotal-(rateFWT*subTotal)-(rateFICA*subTotal)-(subTotal*stateTaxRrate);
	cout<<"End"<<endl;
    system("pause");
	return 0;
}//end of program
