namespace fordon;

public enum VehicleType {
	Car,
	Motorcycle,
	Truck
}

public enum FuelType {
	Diesel,
	Gasoline,
	Electric
}


class Fordon {
	public VehicleType Type { get; private set; }
	public FuelType Fuel { get; private set; }
	public string RegNr { get; private set; }
	public string Brand { get; private set; }
	public string Color { get; private set; }
	public bool IsInspected { get; private set; }

	public Fordon(VehicleType vehicleType, FuelType fuel, string brand, string color, string regNr){
		this.Type = vehicleType;
		this.Fuel = fuel;
		this.Brand = brand;
		this.Color = color;
		this.RegNr = regNr;
	}

	void ChangeColor(string color){
		this.Color = color;
	}

	void ChangeInspected(){
		if (IsInspected){
			IsInspected = false;
		}
		else {
			IsInspected = true;
		}
	}

	void ChangeInspected(bool status){
		IsInspected = status;
	}

	void ChangeRegNr(string newRegNr){
		RegNr = newRegNr;
	}
}
