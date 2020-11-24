<Query Kind="Program" />

void Main()
{
	
	var namedArray = new NamedIntArray();
	
	namedArray["zero"] = 99; //set
	namedArray["one"] = 11111; //set
	
	int arrayValue = namedArray["one"];
	
	Console.WriteLine(arrayValue.ToString());
	
}

class NamedIntArray
{

	private int[] array = new int[100];

	public int this[string name]
	{
		get
		{
			switch (name)
			{
				case "zero":
					return array[0];
				case "one":
					return array[1];
				default:
					return -1;
			}
		}
		set
		{
			switch (name)
			{
				case "zero":
					array[0] = value;
					break;
				case "one":
					array[1] = value;
					break;
			}
		}
	}
}
