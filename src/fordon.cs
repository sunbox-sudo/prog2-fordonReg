using System.Text.Json;
using System.Text.Json.Serialization;

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

	public virtual void printInfo(){
		Console.Write($"{RegNr}, {Brand}, {Color}, IsInspected: {IsInspected}");
	}
}

// whole list should be sved so this is bad.
//
// public virtual void saveJson(){
// 	Console.WriteLine("placeholder: Save Joson");
// }
//
// public virtual void loadJson(){
// 	Console.WriteLine("placeholder: Load Joson");
// }

// error CS7036 solved with help of ai
// I got the knowlagde of you nedeed " : base(args)"
public class Car : Fordon{
	public int deckCount { get; private set; }
	public float topKmph { get; private set; }

	[JsonConstructor]
	public Car(string brand, string color, string regNr, float topKmph, int deckCount) : base(brand, color, regNr){
		this.topKmph = topKmph;
		this.deckCount = deckCount;
	}

	public override void printInfo(){
		base.printInfo();
		Console.Write($", deck: {deckCount}, top {topKmph}\n");
	}


}

public class Boat : Fordon{
	public int PropelerCount { get; private set; }

	[JsonConstructor]
	public Boat(string brand, string color, string regNr, int propelerCount) : base(brand, color, regNr){
		this.PropelerCount = propelerCount;
	}

	public override void printInfo(){
		base.printInfo();
		Console.Write($", Probler count:{PropelerCount}\n");
	}
}
