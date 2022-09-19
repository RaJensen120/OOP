namespace kg2
{
    class Manager : Employee
    {
        public Manager(string name, string job, int salary, int seniority, int bonus)
            :base(name, job, salary, seniority)
        {
            Bonus = bonus;
        }
        
        public int Bonus { get; }
        
        public int calculateYearlySalary(Manager manager)
        {
            return manager.Salary * 12 * (1 + manager.Seniority/10) + manager.Bonus;
        }
        



    }
}