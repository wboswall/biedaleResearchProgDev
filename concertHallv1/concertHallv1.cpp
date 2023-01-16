#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double orchestra=0.0;
    double mainFloor=0.0;
    double balcony=0.0;
    const double O_PRICE=0.0;
    const double M_PRICE=0.0;
    const double B_PRICE=0.0;
    cout<<"Enter number of orchestra tickets: "<<endl;
    cin>>orchestra;
    cout<<"Enter number of main floor tickets: "<<endl;
    cin>>mainFloor;
    cout<<"Enter number of balcony: "<<endl;
    cin>>balcony;
    totalOrchestra=orchestra*OPrice;
    totalMainFloor=mainFloor*MPrice;
    totalBalcony=balcony*BPrice;
    totalRevenue=totalOrchestra+totalMainFloor+totalBalcony;
    cout<<"Total Orchestra: "<<totalOrchestra<<endl;
    cout<<"Total Main Floor: "<<totalMainFloor<<endl;
    cout<<"Total Balcony: "<<totalBalcony<<endl;
    cout<<"Total Revenue of all three levels is: "<<totalRevenue<<endl;
    cout<<"End"<<endl;	
    system("pause");
	return 0;
}//end of program
