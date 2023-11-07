using System;
using System.IO;
using System.Runtime.Serialization;

/*
	Example for custom exception : 


	Suppose I have asp.net web application.The application should allow the user to have only one logged in session.
	If the user is already logged in and if he opens another browser window and tries to login again the application
	should throw an error stating he is already logged in another browser window.


*/


/*

	Serialization :


	Use of Serialization : 
	-If there are two applications and they wanted to talk each other.
	 Suppose I have applications A1 and A2 ....If I want A1 application want to talk with application A2 ...So A1 application cross 
	 the boundry and talk with A2 application.
	-When you have to move objects across application boundries those object need to be serializable.
	-Serialization is nothing but breaking down that object into packets that can be transmitted over a network. If you want move your object from
	 one application domain to another application aomain over the network then class has to be serializable.

*/

public class CustomExceptionDemo
{
	public static void Main()
	{
		throw new UserAlreadyLoggedInException("User is logged in - no duplicate seesion allowed.");
	}
}


[Serializable]
public class UserAlreadyLoggedInException : Exception 
{
	public UserAlreadyLoggedInException() : base()
	{

	}

	public UserAlreadyLoggedInException(string message) : base(message)
	{

	}


	// To track inner exception we use another oveloaded version of constructor

	public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
	{

	}


	public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
	{
		
	}

}