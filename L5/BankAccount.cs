using L5;

namespace L5
{
    public class BankAccount : Program
    {
        public BankAccount(int balance)
        {
            Balance = balance;
        }
        
        public int Balance { get; set; }

        public void Start()
        {
            bool done = false;
            while (!done)
            {

                Console.WriteLine("Press 'd' to deposit, Press 'w' to withdraw, Press 'b' to check balance and Press 'e' to exit");
                
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D:
                        Console.WriteLine("Input amount to deposit: ");
                        int depositAmount = Utilities.ReadInteger();
                        try
                        {
                            Deposit(depositAmount);
                        }
                        catch (NegativeIntegerException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        
                        
                        break;
                    
                    case ConsoleKey.W:
                        Console.WriteLine("Input amount to withdraw");
                        int withdrawAmount = Utilities.ReadInteger();
                        try
                        {
                            Withdrawal(withdrawAmount);
                        }
                        catch (NegativeIntegerException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (InsufficientFundsException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        
                        break;
                    
                    case ConsoleKey.B:
                        Console.WriteLine("Your current balance is: " + Balance);
                        break;
                    
                    case ConsoleKey.E:
                        done = true;
                        break;
                }
            }
            
        }


        public void Deposit(int depositAmount)
        {
            if (depositAmount < 0)
            {
                throw new NegativeIntegerException();
            }
            Balance += depositAmount;
        }

        public void Withdrawal(int withdrawalAmount)
        {
            
            if (Balance - withdrawalAmount < 0)
            {
                throw new InsufficientFundsException();
            }

            if (withdrawalAmount < 0)
            {
                throw new NegativeIntegerException();
            }

            Balance -= withdrawalAmount;
            
        }
    }   
}