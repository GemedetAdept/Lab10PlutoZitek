using menudriver;
// CS 1400 - Lab 10, Pluto Zitek

MenuDriver selectionMenu = new MenuDriver();

string[] options = new string[] {

	"Option A", 
	"Option B", 
	"Option C"	
};

selectionMenu.AddOptions(options);

while (selectionMenu.menuLoop){

	Console.Clear();
	selectionMenu.DisplayMenu();
	selectionMenu.SetMenuCursor();

	switch(selectionMenu.selectedItem) {

		case 0:
			showItem();
			break;
		case 1: 
			showItem();
			break;
		case 2:
			showItem();
			break;
		default:
			break;
	}
}

void showItem() {
	Item newItem = new Item();

	PrintData(newItem);

	void PrintData(Item itemObject) {

		Console.WriteLine(itemObject.title);
		Console.WriteLine(itemObject.description);
		Console.WriteLine(itemObject.isComplete);
		Console.WriteLine(itemObject.startTime);

		if (itemObject.endTime !> itemObject.startTime) {
			Console.WriteLine(itemObject.endTime);
		}
	}
}
