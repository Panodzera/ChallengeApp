using ConsoleApp1;

Employee pracownik1 = new Employee("Monika", "Kot", 33);
Employee pracownik2 = new Employee("Ewa", "Kinga", 27);
Employee pracownik3 = new Employee("Piotr", "Kubus", 28);

pracownik1.AddScore(5);
pracownik1.AddScore(2);
pracownik1.AddScore(5);
pracownik1.AddScore(7);
pracownik1.AddScore(1);

pracownik2.AddScore(8);
pracownik2.AddScore(9);
pracownik2.AddScore(4);
pracownik2.AddScore(5);
pracownik2.AddScore(3);

pracownik3.AddScore(4);
pracownik3.AddScore(5);
pracownik3.AddScore(6);
pracownik3.AddScore(7);
pracownik3.AddScore(8);

List<Employee> employees = new List<Employee>()
{
    pracownik1, pracownik2, pracownik3
};

int maxResult = -1;
Employee pracownikWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        pracownikWithMaxResult = employee;
    }
}
// dla lepszej czytelnosci dwa razy zrobiony enter
// C.W ($"....{p.N} enter {p.S} {p.A}... enter ....{p.R} ");

Console.WriteLine($"najlepszy wynik ma: {pracownikWithMaxResult.Name}" +
    $" {pracownikWithMaxResult.Surname} {pracownikWithMaxResult.Age} lat. " +
    $"Ilosć punktow: {pracownikWithMaxResult.Result}  ");
