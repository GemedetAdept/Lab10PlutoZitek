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

}