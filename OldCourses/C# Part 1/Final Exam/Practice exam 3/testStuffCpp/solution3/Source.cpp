#include <iostream>
#include <string>

using namespace std;
using std::cin; using std::cout; using std::string;
char *replaceAll(const char* text, const char* what, const char* with);
char *replaceAll(const char* text, const char* what, const char* with){
	int i =0;
	int len = strlen(text);
	int lenWhat = strlen(what);
	int lenWith = strlen(with);
	int correction = lenWhat - lenWith;
	int times =0;
	int bufferLen= len -(lenWhat - lenWith);
	char*  buffer;
	
	buffer= new char [bufferLen+1];
	memset(buffer, '\0', bufferLen+1);
	bool isTheWord =false;
	for (int k = 0; k < len-(lenWhat -lenWith);k++)
	{
		for (int j = k,l=0; l<strlen(what); j++,l++)
		{
			if (text[j+times*correction] ==  what[l])
			{
				isTheWord = true;
			}
			else
			{
				isTheWord= false;
				break;
			}
		}

		if (isTheWord )
		{
			
			for (int m = k, j=0;( m < k+strlen(what)) && (j<strlen(with)); m++,j++)
			{
				buffer [m] = with[j];
			}
			times++;
			k = k+lenWith-1;
		}else
		{// TO DO 
			// Make the correction when it moves with a different length of the words to move the whole thing 
			buffer[k] = text[k+times*correction];
		}

	}

	return buffer;
}
int main ()
{  char* arr = new char[];
cin.getline(arr,1024);

arr = replaceAll (arr,"gosho","ivan"); //fix ivan s gosho razmeneni
int i =0;
while (arr[i]!='\0')
{
	cout<<arr[i];
	i++;
}

return 0;
}