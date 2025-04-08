

using Spectre.Console;
using static libraryMng.Enums;

namespace libraryMng
{
    internal class UserInterface
    {

        internal static void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                var choice = AnsiConsole.Prompt(
                        new SelectionPrompt<MenuOption>()
                        .Title("What do you want to do next?")
                        .AddChoices(Enum.GetValues<MenuOption>()));

                switch (choice)
                {
                    case MenuOption.Viewbooks:
                        BookController.ViewBooks();
                        break;
                    case MenuOption.AddBook:
                        BookController.AddBook();
                        break;
                    case MenuOption.DeleteBook:
                        BookController.DeleteBook();
                        break;
                }
            }
        }
    }
}
