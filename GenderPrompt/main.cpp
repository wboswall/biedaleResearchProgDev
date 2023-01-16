#include <iostream>

using namespace std;

int main()
{
    char gender;
    char result;
    cout<<"Please enter your gender (M/F)\n";
    cin>>gender;
    if(toupper(gender)=='M')
	{
		result=gender;
		cout<<"Your gender is :"<<result<<"\n";
	}
	else
	{
		result=gender;
		cout<<"Your gender is: "<<gender<<"\n";
	}
    return 0;
}
