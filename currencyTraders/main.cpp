#include <iostream>

using namespace std;

int main()
{
    double dollar, pound, peso, yen;
    cout<<"enter the amount of dollar\n";
    cin>>dollar;
    pound=dollar*0.571505;
    peso=dollar*10.7956;
    yen=dollar*112.212;
    cout<<"the amount of the dollar in pound is" <<pound<<endl;
    cout<<"the amount o the dollar in peso is"<<peso<<endl;
    cout<<"the amount of the dollar in yen is" <<yen<<endl;
    return 0;
}
