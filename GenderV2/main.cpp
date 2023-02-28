#include <iostream>

using namespace std;

int main()
{
    char gender, result;
    cout<<"Please enter you gender(M/F)\n";
    cin>>gender;
    if(toupper(gender)=='M')
	{
		result=gender;
		cout<<"your gender is Male.\n"<<result;
	}
	else
	{
		result=gender;
		cout<<"Your gender is Female.\n";
	}
    return 0;
}
