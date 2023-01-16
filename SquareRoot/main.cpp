#include <iostream>
#include <cmath>
using namespace std;

double sqrt (double x, double y, double a);

int main()
{
    double x,y, answer;
    cout<<"Enter x value\n";
    cin>>x;
    cout<<"Enter Y value\n";
    cin>>y;
    answer=sqrt(pow(x,2)*pow(y,3));
    cout<<"Answer: "<<answer<<endl;
    cin.get();
    return 0;
}
double sqrt(double x, double y, double a)
{
	return sqrt(pow(x,2)*pow(y,3));
}
