/*
 *The Colfax Products Solution
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
void calcCommission();
int main(int argc, char *argv[])
{
	calcCommission();
	return 0;
}
void calcCommission()
{
	double saleOne = 0.00;
	double saleTwo = 0.00;
	double totalSales= 0.00;
	double commissionRate = 0.00;
	double commission = 0.00;
	
	cout << "Enter the first sale: $" << endl;
	cin >> saleOne;
	cout << "Enter the second sale: $" << endl;
	cin >> saleTwo;
	cout << "Enter the commission rate: %" << endl;
	cin >> commissionRate;
	totalSales = saleOne + saleTwo;
	commission = totalSales * commissionRate;
	cout << "The total sales are: $" << fixed << setprecision(2) << totalSales << endl;
	cout << "The commission is: $"<< fixed << setprecision(2) << commission << endl;
}