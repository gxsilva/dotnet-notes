public class Pessoa
{
	required public string Nome { get; set; }
	public int Age { get; set; }

	public void Show()
	{
		Console.Write($"Hello World: {Nome} with age {Age}");
	}
}