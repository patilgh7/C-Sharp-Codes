
- Partial Method are private by default.

- For partial method you have provide method declaration and method implementation otherwise it will give compiler error.
  
  e.g. partial void SamplePartialMethod();    // method declarataion 

        partial void SamplePartialMethod()    // method implementation ...this implementation can be in same or different physical file.
  	{
      		Console.WriteLine("Sample Partial Method Invoked");
  	}

  	Only method declarataion is must and its implemetation.

- Partial Method return type must be void. Other return type is compile time error.  

- Partial method must be declared within a partial class or partial struct.

- A partial method can be implemented only once. Trying to implement a partial method more than once, raises compile time error.  