namespace menu;

class Menu {

	string name;
	List<string> options = new();
	int index;

	public Menu(string name, List<string> options){
		this.name = name;
		this.options = options;
	}

	public int run(){
		while (true){
			draw();

			int result = input();

			if (result != -1){
				return result;
			}
		}
	}

	void draw(){
		Console.Clear();
		int i = 0;
		foreach (string option in options){
			if ( i == index){
				Console.ForegroundColor = ConsoleColor.Green;
			}

			Console.WriteLine(option);
			Console.ResetColor();
			i++;
		}
	}

	int input(){
		ConsoleKey inputKey;

		inputKey = Console.ReadKey(true).Key;
		switch(inputKey){
			case ConsoleKey.K:
			case ConsoleKey.UpArrow:
				index--;
				break;

			case ConsoleKey.J:
			case ConsoleKey.DownArrow:
				index++;
				break;
			case ConsoleKey.Enter:
				return index;
		}
		if (index < 0) index = options.Count - 1;
		if (index > options.Count - 1) index = 0;
		return -1;
	}
}
