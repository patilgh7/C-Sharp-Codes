using System;


class Circle
{
	// static field declare Pi
	static float _PI;
	int _Radius;

	static Circle()
	{
		Console.WriteLine("Static Constructor Called");
		Circle._PI = 3.141F;
	}

	// Instance Constructor
	public Circle(int Radius)
	{
		Console.WriteLine("Instance Constructor Called");
		this._Radius = Radius;
	}

	public float CalculateArea()
	{
		return _PI * _Radius * _Radius;
	}
}

class StaticInstanceDemo
{
	static void Main()
	{
		Circle C1 = new Circle(5);
		float Area = C1.CalculateArea();

		Console.WriteLine("Area = {0} ",Area);



		Circle C2 = new Circle(9);
		float Area2 = C2.CalculateArea();

		Console.WriteLine("Area2 = {0} ",Area2);
	}
}