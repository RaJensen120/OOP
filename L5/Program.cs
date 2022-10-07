using L5;

namespace L5
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount("Jens",2000); 
            bankAccount1.Start();
        }
    }
}