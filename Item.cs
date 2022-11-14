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

		// Use Get/UseCursorPosition to have character limit underline
		Console.Write("Enter title (0-72 chars): ");
		(int, int) inputTitle = Console.GetCursorPosition();
		Snippet.LineBreak();
		Console.Write(new string ('┄', 26+72) + "\n");
		Console.SetCursorPosition(inputTitle.Item1, inputTitle.Item2);
		newItem.title = Console.ReadLine();

		Snippet.LineBreak();
		Snippet.LineBreak();

		Console.Write("Enter description: ");
		newItem.description = Console.ReadLine();

		incompleteItems += 1;
		newItem.index = incompleteItems;

		return newItem;
	}

	// Displays the to-do items in a pretty ANSI box
	public static void DrawItem(Item item) {

		string indexString = item.index.ToString();
		string indexLineWidth = new string ('┄', indexString.Length);

		string boxLineWidth = new string ('┄', 72);
		string boxSpaceWidth = new string (' ', 72-item.title.Length);

		int startTimeLength = item.startTime.ToString().Length;
		string startSpaceWidth = new string (' ', 76-startTimeLength);
		string startLineWidth = new string ('┄', 76);

		char[] descriptionChars = item.description.ToArray();
		List<char> descriptionSplit = new List<char>();

		descriptionSplit.Add('┆');
		descriptionSplit.Add(' ');
		for (int i=0; i < item.description.Length; i++) {

			if (i % 75 == 0 && i != 0) {

				if (descriptionChars[i] == '.') descriptionSplit.Add(' ');
				if (descriptionChars[i] != ' ') descriptionSplit.Add('-');

				descriptionSplit.Add(' ');
				descriptionSplit.Add('┆');
				descriptionSplit.Add('\n');
				descriptionSplit.Add('┆');
				descriptionSplit.Add(' ');
			}

			descriptionSplit.Add(descriptionChars[i]);
		}

		string boxTopLine = "┌┄" + indexLineWidth + "┄┬┄" + boxLineWidth + "┄┐";
		Console.WriteLine(boxTopLine);
		Console.WriteLine("┆ " + item.index + " ┆ " + item.title + boxSpaceWidth + " ┆");
		Console.WriteLine("├┄" + indexLineWidth + "┄┴┄" + boxLineWidth + "┄┤");

		foreach (char character in descriptionSplit) Console.Write(character);
		Snippet.LineBreak();

		Console.WriteLine("├┄" + indexLineWidth + "┄┄┄" + boxLineWidth + "┄┤");
		Console.WriteLine("┆ " + item.startTime + startSpaceWidth + " ┆");
		Console.WriteLine("└┄" + startLineWidth + "┄┘");

		Snippet.LineBreak();
	}
}