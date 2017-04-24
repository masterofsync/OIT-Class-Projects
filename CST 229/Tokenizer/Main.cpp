#pragma warning(disable:4996)
#include "Main.h"
#include <iostream>
#include<fstream>
#include<string>
#include<vector>
#include <ctype.h>
#include<sstream>
#include<boost/algorithm/string/split.hpp>
#include <boost/algorithm/string/classification.hpp>
#include <stdio.h>


using namespace std;

//function that gets filename and returns a string with all file data.
string GetTextFileData(string filename)
{
	string line;
	string fileContent;
	fstream file;

	//opening file
	file.open(filename);

	//Checking for Error
	if (file.fail()){
		cerr << "Error Opening File" << endl;
		//getting out if error opening file
		exit(1);
	}

	//if the file is open
	if (file.is_open())
	{
		//reading until there is line in the textfile
		while (getline(file, line))
		{
			//appending all the lines to one string
			fileContent += line;
		}
	}

	//closing the file
	file.close();

	//returning content if any
	return fileContent;
}

//checks if a char is operator.Returns true if it is
bool IsOperator(char c)
{
	switch (c){
	case '+':return true;
	case '-':return true;
	case '*':return true;
	case '/':return true;
	case '%':return true;
	case '!':return true;
	case '<':return true;
	case '>':return true;
	case '&':return true;
	case '|':return true;
	case '^':return true;
	case '~':return true;
	case '=':return true;
	case ',':return true;
	default:return false;
	}
}

//checks if a char is Symbol.Returns true if it is
bool IsSymbol(char c)
{
	switch (c)
	{
	case '{':return true;
	case '}':return true;
	case '(':return true;
	case ')':return true;
	case ';':return true;
	case '"':return true;
	case '\'':return true;
	default:return false;
	}
}

//function to tokenize. Gets a string and returns a vector of type string (of format: "token,token type").
vector<string> Tokenize(string data)
{
	string identifier;			//to temporarily store identifier
	string digit;				//to temporarily store digit
	vector<string> output;		//final vector to be returned to main

	//variables just to convert char& to string
	stringstream ss;	
	string s;

	int index = 0;

	//for loop to each iterate through each character in the provided string.
	for (char& c : data)
	{
		ss.clear();
		s.clear();

		//conversion from char to string so concatenation can be done by +.
		ss << c;
		ss >> s;

		//if condition to check if it is a digit or alphabet or "_"
		if (isalpha(c) || c == '_' || isdigit(c) || c == '.')
		{
			//if given char is part of identifier, append it to make a single token.
			if (isalpha(c) || c == '_')
			{
				identifier += c;
			}
			else if (isdigit(c) || c == '.')						//else make it a digit token
			{
				if (!identifier.empty())							//making sure digit is not a part of a identifier(i.e.  int data3 = 23)
				{
					identifier += s;								//appending characters to make it a token
				}
				else												//if not part of identifier then make it part of a digit token
				{
					digit += s;										//appending characters to make it a token
				}
			}
			else
			{
				output.push_back(s + ",Unknown Type");				//catching if char is not part of our logic type.
			}
		}
		else if (isspace(c) || IsOperator(c) || IsSymbol(c))		//after space,operator or symbol is spotted in character, some token is complete
		{
			if (!identifier.empty())								//checking if complete identifier is available to make it a token.
			{
				output.push_back(identifier + ",Identifier");		//token has been created so saving it in output vector in the format("var,Identifier")
				identifier.clear();									//clearing the identifier string since a token is already saved
			}

			if (!digit.empty())
			{
				output.push_back(digit + ",Digit");				   //token has been created so saving it in output vector in the format("24,Digit")
				digit.clear();									   //clearing the Digit string since a token is already saved
			}

			if (isspace(c))
			{
				//do nothing just let it iterate
			}
			else if (IsOperator(c))
			{
				output.push_back(s + ",Operator.");				   //saving it in output vector in the format("+,Operator")
			}
			else if (IsSymbol(c))
			{
				output.push_back(s + ",Symbol");				   //saving it in output vector in the format("+,Operator")
			}
			else
			{
				output.push_back(s + ",Unknown Type");			   //catching if char is not part of our logic type. Saving it to output vector
			}
		}
		else
		{
			output.push_back(s + ",Unknown Type");				   //catching if char is not part of our logic type. Saving it to output vector
		}
	}
	return output;
}

int main(){

	string filename;
	string data;
	vector<string> parsedValue;									//vector for separating incoming vector format(i.e. token,tokentype) to token and token type
	int userInput;
	char userChoice;

	do{
		cout <<endl<<endl<<"*******************************************************************************" << endl;
		cout << "****************************Welcome to Tokenizer!******************************" << endl;
		cout << "*******************************************************************************" << endl << endl;
		cout << "Choose a file:" << endl;
		cout << "1. Test File 1" << endl;
		cout << "2. Test File 2" << endl;
		cout << "3. Test File 3" << endl;

		cout << "Choose your option(1-3): ";
		cin >> userInput;

		if (userInput == 1)
		{
			filename = "Test1.txt";
		}
		else if (userInput == 2)
		{
			filename = "Test2.txt";
		}
		else if (userInput == 3)
		{
			filename = "Test3.txt";
		}
		else
		{
			filename.empty();
		}

		if (!filename.empty())
		{
			data = GetTextFileData(filename);
			vector<string> list = Tokenize(data);
			cout << endl << endl << "Result:" << endl;
			for (vector<string>::iterator it = list.begin(); it != list.end(); ++it) {
				boost::split(parsedValue, *it, boost::is_any_of(","));
				cout << parsedValue[0] << " is " << parsedValue[1] << endl;
			}
			filename.empty();
		}
		else
		{
			cout << endl << "Invalid choice!" << endl;
		}
		cout << endl << "Try Another?(y/n):  ";		
		cin >> userChoice;
	} while (userChoice == 'y' || userChoice =='Y');	 //repeat till user wants to continue
	return 0;
}

