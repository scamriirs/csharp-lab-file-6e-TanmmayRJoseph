// * Q2) an company gives bonus to its employees based on theier experience less than 5 years no bonus , 5 to 10 years 10% of the salary 11 to 15 years 15% of its salary above 15years  20% of its salary take employee salary and year of service as input from the user 

using System;
class bonusFinder
{
   public static void Main(string[] args){
      Console.Write("Enter the employee salary: ");
      int salary = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the year of service: ");
      int years = Convert.ToInt32(Console.ReadLine());
      int bonus = 0;
      if(years < 5)
      {
         Console.WriteLine("No bonus is offered");
      }
      else if(years >= 5 && years <= 10)
      {
         bonus = (salary * 10) / 100;
         Console.WriteLine($"Bonus is: Rs. {bonus}");
      }
      else if(years >= 11 && years <= 15)
      {
         bonus = (salary * 15) / 100;
         Console.WriteLine($"Bonus is: Rs. {bonus}");
      }
      else
      {
         bonus = (salary * 20) / 100;
         Console.WriteLine($"Bonus is: Rs. {bonus}");
      }
   }
}