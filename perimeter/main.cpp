#include <iostream>

using namespace std;

double calcArea(double l, double w);
double calcPerimeter(double l, double w);

int main()
{
	double length, width, area, perimeter;
	cout <<"Enter a length\n";
	cin>>length;
	cout<<"Enter a wdith\n";
	cin>>width;
	area=calcArea(length, width);
	perimeter=calcPerimeter(length,width);
	cout<<"The area is "<<area<<endl;
	cout<<"The perimeter is "<<perimeter<<endl;
	cin.get();
    return 0;
}
double calcArea(double l, double w)
{
	return l*w;
}
double calcPerimeter(double l, double w)
{
	return 2*(l+w);
}
