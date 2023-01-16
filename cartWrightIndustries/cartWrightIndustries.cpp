#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    const double FICA=1.2;
    const double FWT=1.08;
    double weeklyNetPay=0.0;
    double grossPayWeekly=0.0;
    const STATE_TAX=1.04;
    cout<<"Enter gross weekly pay: "<<endl;
    cin>>grossWeeklyPay;
    weeklyNetPay=(grossPayWeekly*FICA)-(grossPayWeekly*FWT)-(grossPayWeekly*STATE_TAX);
    cout<<"End"<<endl;	
    system("pause");
	return 0;
}//end of program
