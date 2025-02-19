//Q1)write a program to automate the admission offer letter generation

/*
name,course,year,fees of the student will vary individually
but
college name,address,brading,disclaimer will be same
*/

using System;

class AdmissionOfferLetter
{
    static string collegeName = "XYZ Institute of Technology";
    static string collegeAddress = "123 Main Street, City, Country";
    static string branding = "Shaping the Future Through Excellence";
    static string disclaimer = "This is a system-generated letter and does not require a signature.";

    static void GenerateOfferLetter(string name, string course, int year, double fees)
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"           {collegeName}");
        Console.WriteLine($"           {collegeAddress}");
        Console.WriteLine($"           {branding}");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Date: {DateTime.Now.ToShortDateString()}");
        Console.WriteLine();
        Console.WriteLine($"Dear {name},");
        Console.WriteLine($"Congratulations! We are pleased to offer you admission to our {course} program for the academic year {year}.");
        Console.WriteLine($"Your total fees for the course are: ${fees}");
        Console.WriteLine();
        Console.WriteLine("Please confirm your acceptance by the due date mentioned in the admission guidelines.");
        Console.WriteLine();
        Console.WriteLine($"Regards,");
        Console.WriteLine($"Admissions Office");
        Console.WriteLine($"{collegeName}");
        Console.WriteLine();
        Console.WriteLine($"Disclaimer: {disclaimer}");
        Console.WriteLine("--------------------------------------------------");
    }

    static void Main()
    {
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Course Name: ");
        string course = Console.ReadLine();
        Console.Write("Enter Admission Year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter Fees Amount: ");
        double fees = double.Parse(Console.ReadLine());

        GenerateOfferLetter(name, course, year, fees);
    }
}
