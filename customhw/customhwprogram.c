#include <stdio.h>
#define MAX 20
int main(void)
{
    char name[MAX];
    char * ptr;
    //printf("name?\n");
    ptr = fgets(name, MAX, stdin);
    printf("Welcome to Hello, World!, "); printf("name?/n",ptr);
    //printf("Your name is %s\n", ptr);
     return 0;
}
