namespace Task1.BaseEntity
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract decimal CalculateSalary();
        public abstract void DisplayInfo();

    }
}
