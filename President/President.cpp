// President.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
using namespace std;
class President
{
private:
 //private default constructor (prohibits creation from outside)
 President() {};
 //private copy constructor (prohibits copy creation)
 President(const President&);
 //private assignment operator (prohibits assignmment)
 const President& operator =(const President&);

 //member data: Presidents name
 string Name;
public:
 //constrolled instantiation
 static President& GetInstance()
 {
  //static opjects are constructed only once
  static President OnlyInstance;
  return OnlyInstance;
 }
 //public methods
 string GetName()
 {
  return Name;
 }
 void SetName(string InputName)
 {
  Name = InputName;
 }
};
int main()
{
 President& OnlyPresident = President::GetInstance();
 OnlyPresident.SetName("Abraham Lincoln");
 //uncomment lines to see how compile failuures prohibit duplicates
 ///President Second;// cannot access constructor
 //President* third = new President();// cannot access constructor
 //President Fourth = OnlyPresident; // cannot access copy constructor
 //OnlyPresident=President::GetInstance();//cannot access operator=
 cout << "The name of the President is: ";
 cout << President::GetInstance().GetName() << endl;
 return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file

