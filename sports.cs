//Q1) write a program if a student is in sports then he/she will get 5 marks extra

using System;

namespace Test {
    class Person {
        public string name;
        public string address;
        public int contactNo;

        public void getdata(string n, string a, int c) {
            name = n;
            address = a;
            contactNo = c;
        }

        public void displaydata() {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Contact No: " + contactNo);
        }
    }

    interface Result {
        void calculateResult(string sports);
    }

    class Student : Person, Result {
        public int id;
        public int marks;

        public void getdata(int i, int m) {  // Renamed from `getedata`
            id = i;
            marks = m;
        }

        public void displaydata() {
            base.displaydata(); // Calls the base class method
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Marks: " + marks);
        }

        public void calculateResult(string sports) {
            if (sports.ToLower() == "yes") {
                marks += 5; // Add 5 marks if the student is in sports
            }
            Console.WriteLine("Final Marks after sports consideration: " + marks);
        }
    }

    public class Program {
        public static void Main() {
            Student s = new Student();
            s.getdata("John Doe", "123 Main St", 987654321);
            s.getdata(101, 80); // Example student data with initial marks 80
            s.displaydata();
            Console.Write("Is the student in sports? (yes/no): ");
            string sports = Console.ReadLine();
            s.calculateResult(sports);
        }
    }
}
