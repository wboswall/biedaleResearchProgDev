#include <iostream>
#include <ctime>
#include <cmath>
#include <stdlib.h>
using namespace std;

void rollADie();

int main()
{

	rollADie();
	cin.get();
    return 0;
}
void rollADie()
{
	    //simulate rolling a die
    srand(static_cast<int>(time(0)));
    for(int i=0; i<10; i++)
		cout<<1+rand()%(6-1+1)<<" "<<endl;
}
