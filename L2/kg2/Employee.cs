namespace kg2
{
    class Employee
    {
        public Employee(string name, string job, int salary)
        {
            Name = name;
            Job = job;
            Salary = salary;
        }
        public string Name { get; }

        public string Job { get; }

        public int Salary { get; }
        
        public void calculateYearlySalary(int Salary)
        {
            
        }
    }
}