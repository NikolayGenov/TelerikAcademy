#include <iostream>
#include <string>
using std::cin;
using std::string;
using std::cout;
using std::endl;
int main()
{
	string line;
	//take the user input
	getline(cin,line);
	int i =0;
	bool goAhead = true;

	//check if the string is empty and if it is wont continue
	if(line.empty())
	{
		goAhead = false;
	}

	//if the first and only char is space it breaks
	if(line[0]==' '&& (line.length()==1))
	{
		goAhead=false;
	}
	//Check if the string is all made from spaces like "      "  
	
	while((line[i]&& i<line.length()-1)&&goAhead) 
	{
		if((line[i] == ' ') && (line[i+1] == ' ')) 
		{
			goAhead = false;
		}
		else 
		{ // if there is one non space before the end we break and continue with processing
			goAhead = true;
			break;
		}
		i++;
	}
	i =0;
	if (goAhead) // if its not all white spaces
	{	
		while(line[i])// go until its not null
		{
			//check if the current char and the next one are spaces
			if((line[i] == ' ') && (line[i+1] == ' ')) 
			{	
				//if they are it erases 1 of them and continue 
				line.erase(i,1);
				continue;
			}
			i++;
		}
		//Removes if there a starting space
		if (line[0]==' ')
			line.erase(0,1);

		//Remove the last space if there is one
		int len =line.length();
		if (line[len-1] ==' ' )
			line.erase(len-1,1);

		//Print out the result
		cout<<line<<"END."<<endl;
	}

	return 0;
}
