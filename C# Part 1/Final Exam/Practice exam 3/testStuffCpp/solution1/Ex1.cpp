#include <iostream>

using namespace std;

int main()
{
    //A place where to store how much of each symbol we have
    int asciiHowMuch [224] = {0};
    //Make an array of the first 256 symbols from ASCII without the first 32 (the special ones)
    char ascii [224];
    for (int j= 0; j<224; j++)
    {
        ascii[j]= (char)(j+32);
    }
    //Take the user input
    char input[1000];
    cin.getline(input,1000);
    //Check for each symbol if it matches with one of the array members and if it does in another array we +1 the value of the symbol
    int i= 0;
    while (input[i] !='\0')
    {
        for (int j= 0; j<224; j++)
        {
            if (input[i]== ascii[j])
            {
                asciiHowMuch[j]++;
            }
        }
        i++;
    }
    //Print out the result for all non zero matches
    for (int j =0; j<224; j++)
    {
        if (asciiHowMuch[j]!=0)
        {
            cout<<"'"<<ascii[j]<<"': "<<asciiHowMuch[j];
            cout<<endl;
        }
    }
    return 0;
}
