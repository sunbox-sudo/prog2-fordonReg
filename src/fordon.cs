namespace fordon;

public abstract class Fordon {
	public string RegNr { get; private set; }
	public string Brand { get; private set; }
	public string Color { get; private set; }
	public bool IsInspected { get; private set; }

	public Fordon(string brand, string color, string regNr){
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

	// error CS7036 solved with help of ai
	// I got the knowlagde of you nedeed " : base(args)"
	public class Car : Fordon{
		int deckCount = 4;
		float topKmph = 100;

		public Car(string brand, string color, string regNr, float topKmph, int deckCount) : base(brand, color, regNr){
			this.topKmph = topKmph;
			this.deckCount = deckCount;
		}

	}

	public class Boat : Fordon{
		int PropelerCount = 2;

		public Boat(string brand, string color, string regNr, int propelerCount) : base(brand, color, regNr){
			this.PropelerCount = propelerCount;
		}
	}

}

