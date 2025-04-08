

using Spectre.Console;
using static libraryMng.Enums;


namespace libraryMng
{
    internal class UserInterface
    {

        private BookController BooksController = new BookController();

        internal void MainMenu()
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
                        BooksController.ViewBooks();
                        break;
                    case MenuOption.AddBook:
                        BooksController.AddBook();
                        break;
                    case MenuOption.DeleteBook:
                        BooksController.DeleteBook();
                        break;
                }
            }
        }
    }
}