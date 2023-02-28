// MyString.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#pragma warning(disable : 4996)
using namespace std;
class MyString
{
private:
 char* Buffer;
public:
 //constructor
 MyString(const char* InitialInput)
 {
  if (InitialInput != NULL)
  {
   Buffer = new char[strlen(InitialInput) + 1];
   strcpy(Buffer, InitialInput);
  }
  else
   Buffer = NULL;
 }
 //copy constructor
 MyString(const MyString& CopySource)
 {
  if (CopySource.Buffer != NULL)
  {
   Buffer = new char[strlen(CopySource.Buffer) + 1];
   strcpy(Buffer, CopySource.Buffer);
  }
  else
   Buffer = NULL;
 }
 ~MyString()
 {
  if (Buffer != NULL)
   delete[] Buffer;
 }
 int GetLength()
 {
  return strlen(Buffer);
 }
 const char* GetString()
 {
  return Buffer;
 }
};
class Human
{
private:
 int Age;
 bool Gender;
 MyString Name;
public:
 Human(const MyString& InputName, int InputAge, bool InputGender)
  :Name(InputName), Age(InputAge), Gender(InputGender) {}
 int GetAge()
 {
  return Age;
 }
};
int main()
{
 MyString FirstMan("Adam");
 MyString FirstWoman("Eve");
 cout << "Sizeof(MyString) = " << sizeof(MyString) << endl;
 cout << "Sizeof(FirstMan) = " << sizeof(FirstMan) << endl;
 cout << "Sizeof(FirstWoman) = " << sizeof(FirstWoman) << endl;
 Human FirstMaleHuman(FirstMan, 25, true);
 Human FirstFemaleHuman(FirstWoman, 18, false);
 cout << "Sizeof(Human) = " << sizeof(Human) << endl;
 cout << "Sizeof(FirstMaleHuman) = " << sizeof(FirstMaleHuman) << endl;
 cout << "Sizeof(FirstFemaleHuman) = " << sizeof(FirstFemaleHuman) << endl;
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
