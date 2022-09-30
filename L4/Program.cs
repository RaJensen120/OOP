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
        }











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
