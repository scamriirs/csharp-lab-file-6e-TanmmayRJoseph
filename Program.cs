// * Q1) an e-commerce website provides cashback based the purchase amt below 1000 no cashback is offered ,1001 to 5000 5% cashback is offered ,5001 to 10000 10 % cashback above 10000 15% take purchase amt as input from the user and calculate the cashback amt given on a particular purchase

// using System;
// class discountFinder
// {
//    public static void Main(string[] args){
//       Console.Write("Enter the purchase amount: ");
//       int purchaseAmt = Convert.ToInt32(Console.ReadLine());
//       int cashBack = 0;
//       if(purchaseAmt < 1000)
//       {
//          Console.WriteLine("No cashback is offered");
//       }
//       else if(purchaseAmt >= 1001 && purchaseAmt <= 5000)
//       {
//          cashBack = (purchaseAmt * 5) / 100;
//          Console.WriteLine($"Cashback is: Rs. {cashBack}");
//       }
//       else if(purchaseAmt >= 5001 && purchaseAmt <= 10000)
//       {
//          cashBack = (purchaseAmt * 10) / 100;
//          Console.WriteLine($"Cashback is: Rs. {cashBack}");
//       }
//       else
//       {
//          cashBack = (purchaseAmt * 15) / 100;
//          Console.WriteLine($"Cashback is: Rs. {cashBack}");
//       }
//    }  
// }

//-------------------------------------------------------------------------------------------------------//

// * Q2) an company gives bonus to its employees based on theier experience less than 5 years no bonus , 5 to 10 years 10% of the salary 11 to 15 years 15% of its salary above 15years  20% of its salary take employee salary and year of service as input from the user 

// using System;
// class bonusFinder
// {
//    public static void Main(string[] args){
//       Console.Write("Enter the employee salary: ");
//       int salary = Convert.ToInt32(Console.ReadLine());
//       Console.Write("Enter the year of service: ");
//       int years = Convert.ToInt32(Console.ReadLine());
//       int bonus = 0;
//       if(years < 5)
//       {
//          Console.WriteLine("No bonus is offered");
//       }
//       else if(years >= 5 && years <= 10)
//       {
//          bonus = (salary * 10) / 100;
//          Console.WriteLine($"Bonus is: Rs. {bonus}");
//       }
//       else if(years >= 11 && years <= 15)
//       {
//          bonus = (salary * 15) / 100;
//          Console.WriteLine($"Bonus is: Rs. {bonus}");
//       }
//       else
//       {
//          bonus = (salary * 20) / 100;
//          Console.WriteLine($"Bonus is: Rs. {bonus}");
//       }
//    }
// }

//--------------------------------------------------------------------------------------------------------------//

//*Q3) in a coloage cmpus structure parking sysytem is required to effiviiently manage parking fees collection the parking system must classify vegicles into three types VIP/faculty class no parking fees is charged ,student car 10 rupees fees is charged ,visitors car 20 rupees parking fees is charged the system should allow users to register a vehcile entry , automatically collect the total collection and generate a summary report displaying yhe information the no of vehicle parked total no of vehicles parked in each category and total revenue collected use switch case to solve this problem
//*press 1 for VIP car
//*press 2 for student car
//*press 3 for visitor car
//*enter your choice :
//*enter registration no:
//*press 1 for VIP car:
//*if pressed 4 then dispaly total revenue and total car parked

// using System;
// class ParkingSystem
// {
//     static int vipCount = 0, studentCount = 0, visitorCount = 0;
//     static int totalRevenue = 0;

//     static void Main()
//     {
//         while (true)
//         {
//             Console.WriteLine("\n1. VIP Car (No fee)\n2. Student Car (10 rupees)\n3. Visitor Car (20 rupees)\n4. Show Summary\n5. Exit");
//             Console.Write("Enter your choice: ");
//             int choice = int.Parse(Console.ReadLine());

//             if (choice == 1)
//             {
//                 vipCount++;
//                 Console.WriteLine("VIP car registered.");
//             }
//             else if (choice == 2)
//             {
//                 studentCount++;
//                 totalRevenue += 10;
//                 Console.WriteLine("Student car registered. Fee: 10 rupees");
//             }
//             else if (choice == 3)
//             {
//                 visitorCount++;
//                 totalRevenue += 20;
//                 Console.WriteLine("Visitor car registered. Fee: 20 rupees");
//             }
//             else if (choice == 4)
//             {
//                 Console.WriteLine("\n--- Parking Summary ---");
//                 Console.WriteLine($"VIP cars: {vipCount}");
//                 Console.WriteLine($"Student cars: {studentCount}");
//                 Console.WriteLine($"Visitor cars: {visitorCount}");
//                 Console.WriteLine($"Total revenue: {totalRevenue} rupees");
//             }
//             else if (choice == 5)
//             {
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("Invalid choice. Try again.");
//             }
//         }
//     }
// }
//--------------------------------------------------------------------------------------------------------------
//*Q4) create a program to show parameterized constructor in c#
// using System;
// class Program
// {
//     public Program(string name, int age)
//     {
//         Console.WriteLine("Name: " + name);
//         Console.WriteLine("Age: " + age);
//     }

//     static void Main(string[] args)
//     {
//         Program obj = new Program("Tanmmay", 20);
//     }

// }
//*parameterless constructor
// using System;
// class Program
// {
//     public Program()
//     {
//         Console.WriteLine("This is parameterless constructor");
//     }
//     static void Main(string[] args)
//     {
//         Program obj = new Program();
//     }
// }

//* default constructor
// using System;
// class Program
// {
//     public Program()
//     {
//         Console.WriteLine("This is default constructor");
//     }
//     static void Main(string[] args)
//     {
//         Program obj = new Program();
//     }
// }

//---------------------------------------------------------------------------------------------
// *Q5) create a program  to show the usage of static constructor
// using System;

// class Program
// {

//     static Program()
//     {
//         Console.WriteLine("This is a static constructor");
//     }


//     public Program()
//     {
//         Console.WriteLine("This is an instance constructor");
//     }

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Main method starts");


//         Program obj1 = new Program();
//         Program obj2 = new Program();

//         Console.WriteLine("Main method ends");
//     }
// }


//----------------------------------------------------------------------------------------------

//*Q6)creating a object of class having a private constructor show it with a help of a program how can we acess the fields & methods of that class
// using System;

// class Program
// {
//     private string message;


//     private Program()
//     {
//         message = "This is a private constructor";
//         Console.WriteLine(message);
//     }


//     public static Program CreateInstance()
//     {
//         return new Program();
//     }

//     public void ShowMessage()
//     {
//         Console.WriteLine("Accessing method of class with private constructor");
//     }

//     static void Main(string[] args)
//     {
//         Program obj = new Program();
       
//         obj.ShowMessage(); 
//     }
// }

//----------------------------------------------------------------------------------------------
//*Q7)write a program to show usage of this keyword

// using System;
// class Program
// {
//     private string message;

//     public Program(string message)
//     {
//         this.message = message; 
//     }

//     static void Main(string[] args)
//     {
//         Program obj = new Program("Hello from Constructor!");
//         obj.Method1();
//         obj.Method2();
//     }

//     public void Method1()
//     {
//         Console.WriteLine(this.message); 
//     }

//     public void Method2()
//     {
//         this.Method1(); 
//         Console.WriteLine("Method 2");
//     }
// }
//---------------------------------------------------------------------------------------------------
