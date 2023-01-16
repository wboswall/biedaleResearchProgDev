#include <iostream>
#include <ctime>
#include <cmath>
#include <stdlib.h>
using namespace std;

int main()
{
    //simulate rolling a die
    srand(static_cast<int>(time(0)));
    for(int i=0; i<10; i++)
		cout<<1+rand()%(6-1+1)<<" "<<endl;
		cin.get();
    return 0;
}
