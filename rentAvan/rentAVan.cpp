#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double baseFee=0.0;
    double perMileCharge=0.0;
    double numMilesDriven=0.0;
    double totalCost=0.0;
    cout<<"Enter baseFee: "<<endl;
    cin>>baseFee;
    cout<<"Enter per mile charge: "<<endl;
    cin>>perMileCharge;
    cout<<"Enter number of miles driven: "<<endl;
    cin>>numMilesDriven;
    totalCost=baseFee+(numMilesDriven*numMilesCharge);
    cout<<"Total cost: "<<totalCost<<endl;
    cin>>totalCost;
	cout<<"End"<<endl;
    system("pause");
	return 0;
}//end of program
