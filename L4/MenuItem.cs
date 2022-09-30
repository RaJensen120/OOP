namespace L4;

public class MenuItem : Menu
{
    public MenuItem(string title, string content)
        :base (title)
    {
        Title = title;
        Content = content;
    }
    
    public string Content { get; set; }
    
}