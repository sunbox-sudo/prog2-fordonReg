namespace fordon;

enum VehicleType {
	Car,
	Motorcycle,
	Truck
}

enum FuelType {
	Diesel,
	Gasoline,
	Electric
}


class Fordon {
	VehicleType type;
	FuelType fuel;
	string regNr = "";
	string brand = "";
	string color = "";
	bool isInspected = false;

	Fordon(VehicleType vehicleType, FuelType fuel, string brand, string color, string regNr){
		this.type = vehicleType;
		this.fuel = fuel;
		this.brand = brand;
		this.color = color;
		this.regNr = regNr;
	}

	void ChangeColor(string color){
		this.color = color;
	}

	void ChangeInspected(){
		if (isInspected){
			isInspected = false;
		}
		else {
			isInspected = true;
		}
	}

	void ChangeInspected()
}
