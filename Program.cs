// CS 1400 - Lab 10, Pluto Zitek

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