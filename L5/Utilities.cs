namespace L5
{
    public class Utilities // this class contains methods that should not belong to any 'real' class
    {
        public static int ReadInteger() // This method takes input from console and makes sure its an int
        {
            int i = 0;
            bool done = false;
            string stringInt;

            while (!done)
            {

                //Console.WriteLine("Input integer: ");
                stringInt = Console.ReadLine();

                try
                {
                    i = Int32.Parse(stringInt);
                    return i;
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return 1;
        }
    }
}