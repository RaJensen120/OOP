namespace L4;

public class MenuItem : IMenuItem
{
    public MenuItem(string title, string content)
    {
        Title = title;
        Content = content;
    }
    public string Title { get; set; }
    public string Content { get; set; }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine(Content);
        Console.WriteLine("Press 'Enter' to go back to previous directory.");
        Console.ReadLine();
    }
}