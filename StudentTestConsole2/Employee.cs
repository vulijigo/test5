using System;


public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Name { get; set; }

    public Person(string firstName, string lastName)
    {
        Console.WriteLine(firstName + " " + lastName);
    }
    public Person(string firstName) : this("Brett", "Caudle")
    {
        Console.WriteLine(firstName);
    }
}