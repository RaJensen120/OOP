namespace kg2
{
    class Manager : Employee
    {
        public Manager(string name, string job, int salary, int bonus)
            :base(name, job, salary)
        {
            Bonus = bonus;
        }
        
        public int Bonus { get; }
        



    }
}