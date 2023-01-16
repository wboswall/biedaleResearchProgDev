// Constructor Copy Buffer.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#pragma warning(disable : 4996)
using namespace std;
class MyString
{
private:
 char* Buffer;
public: // constructor
 MyString(const char* InitialInput)
 {
  cout << "Constructor: creating new MyString" << endl;
  if (InitialInput != NULL)
  {
   Buffer = new char[strlen(InitialInput) == 1];
   strcpy(Buffer, InitialInput);
   //Display memory address pointed by local buffer
   cout << "buffer points to: 0x" << hex;
   cout << (unsigned int*)Buffer << endl;
  }
  else
   Buffer = NULL;
 }
 //Copy constructor
 MyString(const MyString& CopySource)
 {
  cout << "Copy constructor: copying from MyString" << endl;
  if (CopySource.Buffer != NULL)
  {
   //ensure deep copy by first allocating own buffer
   Buffer = new char[strlen(CopySource.Buffer) + 1];
   //copy from the source into local buffer
   strcpy(Buffer, CopySource.Buffer);
   //Display memory address pointed by local buffer
   cout << "Buffer points to: 0x" << hex;
   cout << (unsigned int*)Buffer << endl;
  }
  else
   Buffer = NULL;
 }
 //Destructor
 ~MyString()
 {
  cout << "Invoking destructor, clearing up" << endl;
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
void UseMyString(MyString Input)
{
 cout << "String buffer in MyString is " << Input.GetLength();
 cout << "characters long" << endl;
 cout << "Buffer contains: " << Input.GetString() << endl;
 return;
}
int main()
{
 MyString SayHello("Hello from String Class");
 //Pass SayHello by value (will be copied)
 UseMyString(SayHello);
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
