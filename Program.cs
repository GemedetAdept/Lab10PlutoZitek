// CS 1400 - Lab 10, Pluto Zitek

string[] options = new string[] {

	"Option A", "Option B", "Option C"	
};

MenuDriver selectionMenu = new MenuDriver();

bool boolMainMenu = true;
selectionMenu.AddOption(options);
int activeItem = 0;
while (boolMainMenu){

	Console.Clear();

	selectionMenu.DisplayMenu(activeItem);
	activeItem = selectionMenu.SelectionDriver(activeItem);
}

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
