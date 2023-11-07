using System;

interface IA
{
	void A_Method();
}

class A : IA
{
	public void A_Method()
	{
		Console.WriteLine("A Method");
	}
}

interface IB
{
	void B_Method();
}

class B : IB
{
	public void B_Method()
	{
		Console.WriteLine("B Method");
	}
}


class AB : IA, IB
{
	A a = new A();
	B b = new B();


	public void A_Method()
	{
		a.A_Method();	
	}

	public void B_Method()
	{
		b.B_Method();
	}
}

public class Program
{
	public static void Main()
	{
		AB ab = new AB();

		ab.A_Method();
		ab.B_Method();
	}
}