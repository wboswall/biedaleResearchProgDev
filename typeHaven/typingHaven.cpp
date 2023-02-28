#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double numTypedEnvel=0.0;
    double numTypedPages=0.0;
    double typedEnvelCharge=0.0;
    double typedPageCharge=0.0;
    double totalCost=0.0;
    cout<<"Enter number of envelopes"<<endl;
    cin>>numTypedEnvel;
    cout<<"Enter number of pages"<<endl;
    cin>>numTypedPages;
    cout<<"Enter Envelope charge"<<endl;
    cin>>typedEnvelCharge;
    cout<<"Enter Page charge"<<endl;
    cin>>typedPageCharge;
    totalCost=(numTypedEnvel*typedEnvelCharge)+(numTypedPages*typedPageCharge)
    cout<<"Total cost of both Envelopes and Pages is: "<<totalCost<<endl;
	cout<<"End"<<endl;
    system("pause");
	return 0;
}//end of program
