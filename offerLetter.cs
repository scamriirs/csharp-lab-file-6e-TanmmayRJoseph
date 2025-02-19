using System;

abstract class OfferLetters
{
    public abstract string Name(string name);
    
    public string Designation(string designation)
    {
        return designation;
    }

    public int Payment(int pay)
    {
        return pay;
    }

    public string CompanyName()
    {
        return "XYZ Corporation Pvt. Ltd.";
    }

    public string OfficeAddress()
    {
        return "512, Manhattan, NY";
    }

    public string CompanyBackground()
    {
        return "XYZ Corporation Pvt. Ltd. is a private and registered corporation operating in accordance with the laws provided by the State of New York.";
    }

    public string Disclaimer()
    {
        return "This letter and its contents are confidential in nature and are intended only for the recipient.\n" +
               "If you are not the correct recipient, kindly return it immediately to " + CompanyName() + 
               " and the Official Office.";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Offer Letter Details:");
        Console.WriteLine("---------------------");
        
        // You can't instantiate an abstract class, so you need to create a derived class to use it
        OfferLetterDetails offer = new OfferLetterDetails();
        
        Console.WriteLine("Company Name: " + offer.CompanyName());
        Console.WriteLine("Office Address: " + offer.OfficeAddress());
        Console.WriteLine("Company Background: " + offer.CompanyBackground());
        Console.WriteLine("Disclaimer: " + offer.Disclaimer());
    }
}

class OfferLetterDetails : OfferLetters
{
    public override string Name(string name)
    {
        return name;
    }
}
