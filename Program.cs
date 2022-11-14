using menudriver;
// CS 1400 - Lab 10, Pluto Zitek

List<Item> incompleteItems = new List<Item>();
List<Item> completeItems = new List<Item>();

MenuDriver selectionMenu = new MenuDriver();
string[] options = new string[] {

	"Create New To-Do Item",
	"View Current To-Do Items",
	"Exit Program"
};
selectionMenu.AddOptions(options);

void mainMenu() {
	while (selectionMenu.menuLoop){

		Console.Clear();
		selectionMenu.DisplayMenu();
		selectionMenu.SetMenuCursor();

		switch(selectionMenu.selectedItem) {

			case 0:
				Item newItem = new Item();
				incompleteItems.Add(Item.CreateItem(newItem));
				continue;
			case 1: 
				displayItems(incompleteItems, completeItems);
				break;
			case 2:
				// showItem();
				break;
			default:
				break;
		}
	}
}

mainMenu();

void displayItems(List<Item> incomplete, List<Item> complete) {

	Console.Clear();

	string headerText = "  Current To-Do Items  ";
	int headerCenter = (Console.WindowWidth - headerText.Length)/2;
	string displayHeader = new string(' ', headerCenter);

	Console.WriteLine(displayHeader + headerText);
		
	for (int i=0; i < incomplete.Count; i++)
		Item.DrawItem(incomplete[i]);

	Console.ReadKey();
	mainMenu();
}
