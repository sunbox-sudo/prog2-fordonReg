using menu;

namespace prog2_fordonReg;

class Program
{
    static void Main(string[] args)
    {
	var mainMenu = new Menu("MainMenu", new List<string> { "Option 1", "Option 2" });
	Console.WriteLine(mainMenu.run());
    }
}
