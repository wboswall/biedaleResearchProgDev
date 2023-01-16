#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double price=0.0;
    const double PI=3.1416;
    double total=0.0;
    double diameter=0.0;
    cout<<"Enter price feet only: "<<endl;
    cin>>price;
    cout<<"Enter diameter feet only: " <<endl;
    cin>>diameter;
    total=Price*(PI*diameter);
    cout<<"End"<<endl;	
    system("pause");
	return 0;
}//end of program
