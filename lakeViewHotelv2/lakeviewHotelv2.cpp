/*
 *The Hotel Lakeview Solution
 *Programmed by: William Boswall
 *Location: PEI, Canada
 *Licensed under the GNU Affero General Public License v3.0
 *Program created: 04/30/2022
 *Program modified: 
 *Released: 04/30/2022
 */
#include <iostream>
#include <iomanip>
using namespace std;
//function declaration
void calcRoomCharge();
int main(int argc, char *argv[])
{
	
	calcRoomCharge();
	return 0;
}
void calcRoomCharge()
{
	double numNights = 0.00;
	double nightRate = 0.00;
	double roomSvcCharge = 0.00;
	double telephoneCharge = 0.00;
	double roomCharge = 0.00;
	double totalBill = 0.00;
	cout << "Enter the number of nights\n" << endl;
	cin >> numNights;
	cout << "Enter the nightRate\n" << endl;
	cin >> nightRate;
	cout << "Enter the roomSvcCharge\n" << endl;
	cin >> roomSvcCharge;
	cout << "Enter the telephoneCharge\n" <<endl;
	cin >> telephoneCharge;
	roomCharge = numNights * nightRate;
	totalBill = roomCharge + roomSvcCharge + telephoneCharge;
	cout << "The room charge is: $ " << fixed <<setprecision(2) << roomCharge << endl;
	cout << "The Total of the bill is: $ "<< fixed << setprecision(2) << totalBill << endl;
}