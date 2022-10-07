using L5;

namespace L5
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ReadInteger();
            BankAccount Jens = new BankAccount(2000);
            Jens.Deposit(Jens);
            Console.WriteLine(Jens.Balance);
            Jens.Withdrawal(Jens);
            Console.WriteLine(Jens.Balance);

        }
        
        public static int ReadInteger()
        {
            int i = 0;
            bool done = false;
            string stringInt;

            while (!done)
            {

                Console.WriteLine("Input integer: ");
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