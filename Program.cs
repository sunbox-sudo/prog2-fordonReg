using menu;
using fordon;

namespace prog2_fordonReg;

class Program
{
	Menu mainMenu = new Menu("MainMenu", new List<string> { "Add vehicle", "List Vehicles" });
	List<Fordon> FordonList = new();

	// bootstrap
	static void Main(){
		Console.Clear();
		Program p = new();
		p.Run();
	}

	public void Run()
	{
		Console.WriteLine(mainMenu.run());
		while (true){
			int option = mainMenu.run();

			switch (option){
				case 0:
					addVehicle();
					break;
				case 1:
					listVehicles();
					break;
				default:
					Console.WriteLine("not a valid option, plz rrport the issue");
					break;
			}
		}
	}

	void addVehicle(){
		// Methods for geting data
		VehicleType getType(){
			VehicleType Type = VehicleType.Car;

			//var typeMenu= new Main ("Type Menu", })

		return Type;
	}

	FuelType getFuel(){
		List<string> fuelNames = Enum.GetNames<FuelType>().ToList();
		fuelNames.Add("Another one");

		var FuelTypesOpts = new Menu("Fuel types", fuelNames);

		FuelType fuel = FuelType.Diesel;
		return fuel;
	}

	string getBrand(){
		string brand = "Test";

		return brand;
	}

	string getColor(){
		string color = "red";

		return color;
	}

	string getRegNr(){
		string regNr = "ABC-123";
		return regNr;
	}

	//getting data
	VehicleType type = getType();
	FuelType fuel = getFuel();
	string brand = getBrand();
	string color = getColor();
	string regNr = getRegNr();

	Fordon NewVehicla = new Fordon(type, fuel, brand, color, regNr);

	return;
}

void listVehicles(){
	return;
}
}
