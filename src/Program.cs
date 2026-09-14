using fordon;
using utils.menu;
using utils.debug;
// using utils.get;


namespace prog2_fordonReg;

class Program
{
	// should be array. and array based menu to save prefoemence
	List<string> MenuOptions = new() {"Add vehicle", "List Vehicles"};


	// Temp: fix a better suluition
	// should be one list that it list or 2dinoinson array w/ list inside array or something
	List<Fordon> FordonList = new();
	List<Car> CarList = new();
	List<Boat> BoatList = new();

	// move when ready
	static List<string> TypesOpts = new() {"ALL", "Boat", "Car"};
	Menu TypeMenu = new Menu("Type Menu", TypesOpts);

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
					Debug.Log("MainMenu returned -1 (exited menu)");
					Environment.Exit(0);
					break;
				case -2:
					Debug.Critical("NO options in main menu");
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
			Console.WriteLine("please enter color of the ");
			color = Console.ReadLine();
			return color;
		}

		float getFloat(string question){
			string foo = "";
			float bar = 0f;

			Console.Clear();
			Console.WriteLine(question);
			foo = Console.ReadLine();

			bar = float.Parse(foo);
			return bar;
		}
		int getInt(string question){
			int foo = 3;
			return foo;
		}

		string brand = "";
		string color = "";
		string regNr = "";
		void getBasic(string type){
			brand = getString($"please enter brand of the {type}");
			color = getColor();
			regNr = getString($"please enter reg number of the {type}");
		}

		int opt = TypeMenu.Run();

		switch (opt){
			case 0: // All
				Debug.Warn("Currently a known bug, to lazy to fix");
				break;

			case 1: // boat
				getBasic("boat");
				int propelerCount = getInt("enter propeler count");

				Fordon NewVec_boat = new Boat(brand, color, regNr, propelerCount);
				FordonList.Add(NewVec_boat);

				Boat NewBoat = new Boat(brand, color, regNr, propelerCount);
				BoatList.Add(NewBoat);
				break;

			case 2: // Car
				getBasic("car");
				float topSpeed = getFloat("Top speed of the car (km/h)");
				int deckCount = getInt("deck count");

				Fordon NewVec_car = new Car(brand, color, regNr, topSpeed, deckCount);
				FordonList.Add(NewVec_car);

				Car NewCar = new Car(brand, color, regNr, topSpeed, deckCount);
				CarList.Add(NewCar);
				break;

			default: // Error
				Debug.Error("in typemenu runing inside addVehicle");
				break;
		}
		return;
	}

	// Leist all vehiclas
	void listVehicles(){

		int opt = TypeMenu.Run();

		Console.Clear();

		switch (opt){
			case 0: // All
				foreach (Fordon curFor in FordonList){
					Console.Write(curFor.GetType().Name + " ");
					curFor.printInfo();
				}
				break;
			case 1: //boat
				foreach (Boat curBoat in BoatList){
					curBoat.printInfo();
				}
				break;
			default:
				Debug.Warn("list vehicle faild");
				break;
		}

		Console.ReadKey();
	}
}
