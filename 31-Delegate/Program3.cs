

/*


Delegate :


-Delegate declare like method declaration. 
-Create object of that delegate
-call delegate 

Note : Signature of delegate should always same as method you want to call it. (return type same and if you passes parameter that should be same)



Example : 

public delegate void HelloMethodDelegate(string Message);


Method which I want to call :

public void Hello(string strMessage)
{
	Console.WriteLine("Hello drom delegate);

}



// Call delegate to call method

// Create first delegate object 

HelloMethodDelegate del = new HelloMethodDelegate(Hello); ====> call the method which you want in constructor

del("Hello....!!!);

=====================================================================================================

Note ===>>> :::::


Signature of delegate must match signature of function that you want to call otherwise it will give compiler error 

A delegate is similar to class you can create instance of it and we pass the function name to delegate constructor ...and delegate 
will point to this function which is pass as a parameter.


A delegate is type safe function pointer. That is it holds a reference (Pointer) to a function.





*/