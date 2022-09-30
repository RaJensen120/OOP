namespace L4;

public class Menu
{
    public Menu(string title)
    {
        Title = title;
    }
    
    public string Title { get; set; }

    public List<MenuItem> MenuItems = new List<MenuItem>();

    public void Add(MenuItem item)
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
                if (i == MenuItems.Count)
                {
                    Console.WriteLine(MenuItems[selected].Content);
                }




                    Console.ResetColor();
            }
            //Console.CursorTop = Console.CursorTop - MenuItems.Count;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(MenuItems[selected].Content);
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
                    done = true;
                    break;
                case ConsoleKey.Escape:
                    done = true;
                    break;
            }

            if (!done)
                Console.CursorTop = Console.CursorTop - (MenuItems.Count + 1);
        }

        Console.WriteLine($"{MenuItems[selected].Content}.");
    }
}
