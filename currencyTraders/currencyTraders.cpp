#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    double usDollar=0.0;
    const double YEN=112.212;
    const double PESO=10.7956;
    const double POUND=0.571505;
    double conversionYen=0.0;
    double conversionPESO=0.0;
    double conversionPOUND=0.0;
    cout<<"Enter american currency to be converted to yen, peso and pound: "<<endl;
    cin>>usDollar;
    conversionYen=usDollar*YEN;
    conversionPeso=usDollar*PESO;
    conversionPOUND=usDollar*POUND;
    cout<<"US Dollar to Yen is: "<<conversionYen<<endl;
    cout<<"US Dollar to Peso is: "<<conversionPeso<<endl;
    cout<<"US Dollar to Pound is: "<<conversionPound<<endl;
    cout<<"End"<<endl;	
    system("pause");
	return 0;
}//end of program
