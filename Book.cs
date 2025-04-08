

using Spectre.Console;

namespace libraryMng
{
    internal class Book : LibraryItem
    {
        //public string Name { get; set; } = "Unknown";
        //public int Pages { get; set; } = 0;

        //public Book(string name, int pages)
        //{
        //    Name = name;
        //    Pages = pages;
        //}

        internal string Author { get; set; }
        internal string Category { get; set; }

        internal int Pages { get; set; }

        internal Book(int id, string name , string author, string category, string location, int pages)
            :base(id,name, location )
        {
            Author= author;
            Category= category;
            Pages= pages;  
        }

        //public override void DisplayDetails()
        //{
        //    var panel = new Panel(new Markup($"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]") +
        //                     $"\n[bold]Pages:[/] {Pages}" +
        //                     $"\n[bold]Category:[/] [green]{Category}[/]" +
        //                     $"\n[bold]Location:[/] [blue]{Location}[/]")

        //    {
        //        Border = BoxBorder.Rounded
        //    };
        //    AnsiConsole.Write(panel);

        //    }
        public override void DisplayDetails()
        {
            string bookInfo =
            $"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]\n" +
            $"[bold]Category:[/] {Category}\n" +
            $"[bold]Pages:[/] {Pages}\n" +
            $"[bold]Location:[/] {Location}";

            var panel = new Panel(new Markup(bookInfo))
            {
                Border = BoxBorder.Rounded,
                Header = new PanelHeader($"book {Name}", Justify.Center)
            };

            //AnsiConsole.Write(panel);
        }










    }

}
