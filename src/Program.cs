using fordon;
using utils.menu;

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
		while (true){
			int option = mainMenu.Run();

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
			List<string> fuelNames = Enum.GetNames<VehicleType>().ToList();

			var typesOpts = new Menu("vehicle types", fuelNames);

			VehicleType type = (VehicleType)typesOpts.Run();

			return type;
		}

		FuelType getFuel(){
			// converts Enums to String List
			List<string> fuelNames = Enum.GetNames<FuelType>().ToList();

			var FuelTypesOpts = new Menu("Fuel types", fuelNames);

			FuelType fuel = (FuelType)FuelTypesOpts.Run();
			return fuel;
		}

		string getBrand(){
			string brand = "Test";

			Console.Clear();
			Console.WriteLine("please enter brand of the car");
			brand = Console.ReadLine();
			return brand;
		}

		string getColor(){
			string color = "red";

			Console.Clear();
			Console.WriteLine("please enter color of the car");
			color = Console.ReadLine();
			return color;
		}

		string getRegNr(){
			string regNr = "ABC-123";

			Console.Clear();
			Console.WriteLine("please enter regstration number the car");
			regNr = Console.ReadLine();
			return regNr;
		}

		//getting data
		VehicleType type = getType();
		FuelType fuel = getFuel();
		string brand = getBrand();
		string color = getColor();
		string regNr = getRegNr();

		Fordon NewVehicles = new Fordon(type, fuel, brand, color, regNr);

		FordonList.Add(NewVehicles);

		return;
	}

	// Leist all vehiclas
	void listVehicles(){

		List<string> data = new();

		// func Convert List<Fordon> To List<string > icluding data
		// 	add it to list  repet
		foreach (Fordon curFor in FordonList){
			data.Add($"{curFor.Type}, {curFor.Brand}, {curFor.RegNr}, {curFor.Fuel}, {curFor.Color}, Inspected {curFor.IsInspected}");
		}

		Menu listMenu = new Menu("List Menu", data);

		listMenu.Run();
		return;
	}
}
