namespace L4
{
    public interface IMenuItem
    {
        public string Title { get; }
        
        void Start();
    }
    public class Menu : IMenuItem
    {
        public Menu(string title)
        {
            Title = title;
            MenuItems = new List<IMenuItem>();
        }

        public string Title { get; set; }

        List<IMenuItem> MenuItems { get; set; }

        public void Add(IMenuItem item)
        {
            MenuItems.Add(item);
        }

        public void Start()
        {
            bool done = false;
            int selected = 0;
            while (!done)
            {

                for (int i = 0; i < MenuItems.Count; i++)
                {
                    if (selected == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("> ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }


                    Console.WriteLine(MenuItems[i].Title);
                    Console.ResetColor();
                }

                //Console.CursorTop = Console.CursorTop - MenuItems.Count;
                Console.BackgroundColor = ConsoleColor.Gray;
                //Console.WriteLine(MenuItems[selected].Content);
                Console.ResetColor();



                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selected = Math.Max(0, selected - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        selected = Math.Min(MenuItems.Count - 1, selected + 1);
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        MenuItems[selected].Start();
                        break;
                    case ConsoleKey.Q:
                        done = true;
                        break;
                }

                if (!done)
                    //Console.CursorTop = Console.CursorTop - (MenuItems.Count);
                    Console.Clear();
            }

            Console.WriteLine($"{selected}.");
        }
    }
}