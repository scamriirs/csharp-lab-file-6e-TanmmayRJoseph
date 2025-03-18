using System;

class Person
{
    private string name;  // Private field
    private int age;      // Private field

    // Read-Write Property for Name
    public string Name
    {
        get { return name; }   // Read property
        set { name = value; }  // Write property
    }

    // Read-Write Property for Age with validation
    public int Age
    {
        get { return age; }  // Read property
        set
        {
            if (value > 0)   // Ensure age is positive
                age = value;
            else
                Console.WriteLine("Age must be positive!");
        }
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        // Writing values using set property
        person.Name = "John Doe";
        person.Age = 25;

        // Reading values using get property
        Console.WriteLine("Name: " + person.Name); // Output: Name: John Doe
        Console.WriteLine("Age: " + person.Age);   // Output: Age: 25

        // Trying to set invalid age
        person.Age = -5;  // Output: Age must be positive!
    }
}
