using System.ServiceModel.Syndication;
using System.Xml;
using L4;

namespace L4
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("fancymenu");

            menu.Add(
                new MenuItem(
                    "Punkt1",
                    "Indhold af punkt 1... det er indtil videre bare tekst"));

            menu.Add(
                new MenuItem(
                    "Punkt2 ",
                    "Indhold af punkt 2... det er indtil videre også bare tekst"));

            menu.Add(
                new MenuItem(
                    "Et lidt læ ngere menupunkt ",
                    "Indhold af punkt 3... det er indtil videre også bare tekst"));
            
            menu.Start();

            /*
            int optionsCount = 5;

            int selected = 0;

            bool done = false;

            while (!done)
            {
                for (int i = 0; i < optionsCount; i++)
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

                    Console.WriteLine(i);

                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selected = Math.Max(0, selected - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        selected = Math.Min(optionsCount - 1, selected + 1);
                        break;
                    case ConsoleKey.Enter:
                        done = true;
                        break;
                }

                if (!done)
                    Console.CursorTop = Console.CursorTop - optionsCount;
            }

            Console.WriteLine($"Selected {selected}.");
        }
        */











            /*
            static void Main(string[] args)
            {
                string url = "http://www.dr.dk/nyheder/service/feeds/allenyheder";
                XmlReader reader = XmlReader.Create(url);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();
                foreach (SyndicationItem item in feed.Items)
                {
                    Console.WriteLine(item.Title.Text);
                    //Console.WriteLine(item.Summary.Text);
                }
            }
        }*/
        }
    }
}
