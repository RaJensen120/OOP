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


        public void Deposit(BankAccount account)
        {
            try
            {
                Console.WriteLine("Deposit");
                account.Balance += ReadInteger();
            }
            catch(InsufficientFundsException e)
            {
                
            }
            

        }

        public void Withdrawal(BankAccount account)
        {
            
            
            Console.WriteLine("Withdraw");
            
            account.Balance -= ReadInteger();
            
            //catch(InsufficientFundsException e)
            
                
            

        }
        
        

    }   
}