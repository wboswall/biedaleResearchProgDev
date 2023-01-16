#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

int main()
{
    for(int i=1; i<=4; i++)
    {
		for(int j=1; j<=6; j++)
		cout<<setw(8)<<pow(i,j)<<" ";
		cout<<endl;
    }
    cin.get();
    return 0;
}
