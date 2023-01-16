#include <iostream>

using namespace std;
void calcEnd(int beg, int pur, int sale, int &ending);
int main()
{
	int begVal=1000;
	int purchase=500;
	int sale=200;
	int endVal=0;
	calcEnd(begVal, purchase, sale, endVal);
	cout<<"ending value: "<<endVal<<endl;
    return 0;
}
void calcEnd(int beg, int pur, int sale, int &ending)
{
	ending = beg + pur - sale;
}
