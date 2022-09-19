namespace kg2
{
    class Employee
    {
        public Employee(string name, string job, int salary, int seniority)
        {
            Name = name;
            Job = job;
            Salary = salary;
            Seniority = seniority;
        }
        public string Name { get; }

        public string Job { get; }

        public int Salary { get; }
        
        private int _Seniority { get; set; }
        public int Seniority
        {
            get { return _Seniority; }
            set
            {
                if ( value < 1 || value > 10)
                    throw new Exception("Seniority needs to be between 1-10");
                _Seniority = value;
            }
        }
        
        public int calculateYearlySalary(Employee employee)
        {
            return employee.Salary * 12 * (1 + employee.Seniority / 10);
        }
    }
}