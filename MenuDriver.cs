public class MenuDriver {

	public List<string> menuOptions = new List<string>();

	public void AddOption(string[] options) {

		for (int i=0; i < options.Length; i++) {

			menuOptions.Add(options[i]);
		}
	}

	public void DisplayMenu(int activeItem) {

		string selector = "> ";

		for (int i=0; i < menuOptions.Count; i++) {

			string option = "";

			if (i == activeItem) {
				option += selector;
			}

			option += menuOptions[i];
			Console.WriteLine(option);
		}
	}

	public int SelectionDriver(int activeItem) {

		int optionsCount = menuOptions.Count;
		var keyInput = Console.ReadKey(false);

		if (keyInput.Key == ConsoleKey.UpArrow && activeItem !>= 0) {

			activeItem -= 1;
			return activeItem;
		}

		else if (keyInput.Key == ConsoleKey.DownArrow && activeItem !<= optionsCount) {

			activeItem += 1;
			return activeItem;
		}

		else return activeItem;
	}
}