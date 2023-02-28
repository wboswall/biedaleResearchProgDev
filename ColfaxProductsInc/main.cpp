#include <iostream>
using namespace std;
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
//ColfaxProductsInc calculates the sales by commission rate and displays the sales and commissions.
int main() {
	double sales1 =0.0;
	double sales2 =0.0;
	double commissionRate=0.0;
	double commission1=0.0;
	double commission2=0.0;
	cout << "Please Enter Sales1: \n";
	cin >> sales1;
	cout << "Please Enter Sales2: \n";
	cin >> sales2;
	cout << "Please Enter Commission Rate \n";
	cin >> commissionRate;
	commission1=sales1 * commissionRate;
	commission2=sales2 * commissionRate;
	cout << "Sales for State1 is " << sales1 << "\nCommission is: " << commission1;
	cout << "\n\nSales for State2 is "<< sales2 << "\nCommission is: " << commission2;
	return 0;
}
