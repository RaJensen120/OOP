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
                    "Et lidt længere menupunkt ",
                    "Indhold af punkt 3... det er indtil videre også bare tekst"));

            Menu UnderMenu = new Menu("Undermenu");
            UnderMenu.Add(
                new MenuItem("titel1", "content1"));
            
            UnderMenu.Add(
                new MenuItem("titel2", "content2"));
            
            menu.Add(UnderMenu);
            
            menu.Start();
        }
    }
}
