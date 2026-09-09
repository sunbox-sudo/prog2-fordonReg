using fordon;
using utils.menu;

namespace prog2_fordonReg;

class Program
{
	List<string> MenuOptions = new() {"Add vehicle", "List Vehicles"};
	List<Fordon> FordonList = new();

	// bootstrap
	static void Main(){
		Console.Clear();
		Program p = new();
		p.Run();
	}

	public void Run()
	{
		Menu mainMenu = new Menu("MainMenu", MenuOptions);

		while (true){
			int option = mainMenu.Run();

			switch (option){
				case 0:
					addVehicle();
					break;
				case 1:
					listVehicles();
					break;
				case -1:
					Console.Error("NO options in main menu");
					break;
				default:
					Console.WriteLine("not a valid option, plz rrport the issue");
					break;
			}
		}
	}

	void addVehicle(){
		// Methods for geting data
		string getString(string question){
			string foo = "";

			Console.Clear();
			Console.WriteLine(question);
			foo = Console.ReadLine();
			return foo;
		}

		string getColor(){
			string color = "red";

			Console.Clear();
			Console.WriteLine("please enter color of the car");
			color = Console.ReadLine();
			return color;
		}

		//getting data
		string brand = ("please enter brand of the car");
		string color = getColor();
		string regNr = getString("please enter color of the car");

		// Fordon NewVehicles = new Car(brand, color, regNr);

		// FordonList.Add(NewVehicles);

		return;
	}

	// Leist all vehiclas
	void listVehicles(){

		List<string> data = new();

		// func Convert List<Fordon> To List<string > icluding data
		// 	add it to list  repet
		foreach (Fordon curFor in FordonList){
			data.Add($"{curFor.Brand}, {curFor.RegNr}, {curFor.Color}, Inspected {curFor.IsInspected}");
		}

		Menu listMenu = new Menu("List Menu", data);

		listMenu.Run();
		return;
	}
}
