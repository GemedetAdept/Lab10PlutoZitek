class Item {

	public string title; 
	public string description; 
	public int index;
	public bool isComplete;
	public DateTime startTime;
	public DateTime endTime;

	public static int incompleteItems = 0;
	public int completeItems = 0;

	public Item() {

		title = "Undefined item title";
		description = "Undefined item description";
		isComplete = false;
		startTime = DateTime.Now;
		endTime = startTime.AddDays(-1);
	}

	public static Item CreateItem(Item newItem) {

		Console.Clear();

		Console.Write("Enter title: ");
		newItem.title = Console.ReadLine();

		Snippet.LineBreak();

		Console.Write("Enter description: ");
		newItem.description = Console.ReadLine();

		incompleteItems += 1;
		newItem.index = incompleteItems;

		return newItem;
	}

	public static void DrawItem(Item item) {

		string indexString = item.index.ToString();
		string indexLineWidth = new string ('┄', indexString.Length);

		string titleLineWidth = new string ('┄', item.title.Length);

		string descriptionLineWidth = new string (' ', item.description.Length);

		Console.WriteLine("┌┄" + indexLineWidth + "┄┬┄" + titleLineWidth + "┄┐");
		Console.WriteLine("┆ " + item.index + " ┆ " + item.title + " ┆");

	}
}