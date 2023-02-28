/*	Created on: 26 Dec 2016
	Revised Date:
	Project Name: HooverCollege Tabulator
    Description: Calculates the of total cost of tuition.
	Coded by: WB
*/
#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
   double hoursEnrolled=0.0;
   double const FEE_PER_HOUR=100;
   double ROOM_AND_BOARD_FEE=2000;
   double totalOwed=0.0;
   cout<<"Enter hours enrolled: "<<endl;
   cin>>hoursEnrolled;
   totalOwed=(hoursEnrolled*FEE_PER_HOUR)+ROOM_AND_BOARD_FEE;
   cout<<"Total owed: "<<totalOwed<<endl;
	cout<<"End"<<endl;
    system("pause");
	return 0;
}//end of program
