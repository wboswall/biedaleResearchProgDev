#include <iostream>

using namespace std;

int main()
{
    //displays the number 20,40,60,80,100,120,140,160, and 180 on the screen.  Initialize counter to 10, while the counter is less than 100, display the counter multiplied by 2, then, add 10 to the counter.
    int counter=10;
    while (counter <100)
	{
		cout<<counter*2<<" ";
		counter +=10;
	}
    cin.get();
    return 0;
}
