var name = "Ewa";
var age = 33;
var gender = "Kobieta";

if (gender == "Kobieta")
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, 33 lat");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age >= 30)
    {
        Console.WriteLine("Kobieta powyżej 30 lat");
    }
}
else
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}