#include <iostream>
using namespace std;
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
void calcTotal();
int main(int argc, char** argv) {
	calcTotal();
	return 0;
}
void calcTotal(){
	double cupPrice = 0.0;
	int numCups = 0;
	double platePrice = 0.0;
	int numPlates = 0;
	double salesTax = 0.0;
	double subTotal = 0.0;
	double total = 0.0;
	double totalPlateCost = 0.0;
	double totalCupCost = 0.0;
	double platesPurchased = 0.0;
	double cupsPurchased = 0.0;
	cout << "Enter the number of cups: " << endl;
	cin  >> numCups;
	cout << "Enter the number of plates: " << endl;
	cin >> numPlates;
	cout << "Enter the plate price: " << endl;
	cin >> platePrice;
	cout << "Enter the cup price: " << endl;
	cin >> cupPrice;
	cout << "Enter the sales tax in decimal form for your province/state. For example 15% would be .15: " << endl;
	cin >> salesTax;
	totalPlateCost = platesPurchased * platePrice;
	totalCupCost = cupsPurchased * cupPrice;
	subTotal = totalCupCost + totalPlateCost;
	total = (subTotal * salesTax) + subTotal;
	cout << "The total cost is: " << total << "Thank you for shopping at Party On Supplies.  We appreciate your business." << endl;
}