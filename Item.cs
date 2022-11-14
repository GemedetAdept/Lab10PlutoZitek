class Item {

	public string title; 
	public string description; 
	public bool isComplete;
	public DateTime startTime;
	public DateTime endTime;

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

		return newItem;
	}
}