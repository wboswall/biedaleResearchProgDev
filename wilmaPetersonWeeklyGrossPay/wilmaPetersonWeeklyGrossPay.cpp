#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double hourlyWage=0.0;
    double numHours=0.0;
    double totalPay=0.0;
    cout<<"Enter hourly wage: "<<endl;
    cin>>hourlyWage;
    cout<<"Enter number of hours: "<<endl;
    cin>>numHours;
    totalPay=(hourlyWage*numHours);
    cout<<"Total Pay: "<<totalPay<<endl;
	cout<<"End"<<endl;	
    system("pause");
	return 0;
}//end of program
