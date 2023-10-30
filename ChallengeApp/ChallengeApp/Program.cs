using ChallengeApp;

Employee employee1 = new Employee("Monika", "Kot", 33);
Employee employee2 = new Employee("Ewa", "Kinga", 27);
Employee employee3 = new Employee("Piotr", "Kubus", 28);

employee1.AddScore(5);
employee1.AddScore(9);
employee1.AddScore(4);
employee1.AddScore(7);
employee1.AddScore(8);

employee2.AddScore(8);
employee2.AddScore(9);
employee2.AddScore(7);
employee2.AddScore(5);
employee2.AddScore(6);

employee3.AddScore(5);
employee3.AddScore(6);
employee3.AddScore(7);
employee3.AddScore(8);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}
// zrobiony 2 enter dla kompaktności C.W
Console.WriteLine($"najlepszy wynik ma: {employeeWithMaxResult.Name}" +
    $" {employeeWithMaxResult.Surname} {employeeWithMaxResult.Age}" +
    $" lat. Ilosć punktow: {employeeWithMaxResult.Result}");
