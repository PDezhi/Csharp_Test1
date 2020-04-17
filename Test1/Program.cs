using System;
using System.Collections;
using System.Collections.Generic;

namespace Test1
{
    class Program
    {
        public delegate string HiSalaryEmp(List<Employee> empList);
        public delegate string LowSalaryEmp(List<Employee> empList);
        static void Main(string[] args)
        {
            //1. Which Statement is correct?
            //The answer is a


            //2. Create a class Name is as Employee(id, name, salary)
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee(1, "Tom", 10000,"1 Marie Road"));
            empList.Add(new Employee(2, "Chalie", 20000, "2 Marie Road"));
            empList.Add(new Employee(3, "Delta", 50000,"3 Marie Road"));
            empList.Add(new Employee(4, "Kaiven", 30000,"4 Marie Road"));
            empList.Add(new Employee(5, "Peter", 90000,"6 Marie Road"));

            foreach(Employee emp in empList)
            {
                Console.WriteLine(emp.name);
            }
            HiSalaryEmp hiSalaryEmp = HighestSalaryEmployee;
            Console.WriteLine("The highest salary Employee is {0}.", hiSalaryEmp(empList)); 
            LowSalaryEmp lowSalaryEmp = LowestSalaryEmployee;
            Console.WriteLine("The Lowest salary Employee is {0}.", lowSalaryEmp(empList));


            //3.Use Tuple to create an object which has 3 fields (name, age, address) and print the fields in the console.
            var person = Tuple.Create("Steve",20, "1010 Sant-Cahrtl");
            Console.WriteLine($"name = {person.Item1}, age = {person.Item2}, address = {person.Item3}");

            //4.Use Dictionary to keep the values of Information of 5 employees in question 2.
            IDictionary<int, string> diction = new Dictionary<int, string>();

            foreach (Employee emp in empList)
            {
                diction.Add(emp.id, emp.officeAddress);
            }

            //5. Create a Generic Class the only accepts class reference
            //See MyGenericClass


            //6. Use Extension method for integer to check if the number is dividable by 3
            int i = 10;
            bool result = i.IsDividableBy3();
            Console.WriteLine(result);

            //7 - Write a method that has one string parameter. By Using predicate check if that string has vowel sounds and print all the vowel sounds in the output.

            Predicate<string> IsContainVowel = IsHasVowel;

            bool resultContainsVowel = IsContainVowel("hello world!!");

            Console.WriteLine(resultContainsVowel);

            //8 - (Bonus)Use Event / Func / Action / delegate with 2 classes(student, RegisterStudentOperation).If the student graduates, notifies the RegisterStudentOperation and Prints a message in the console.


            RegisterStudentOperation rso = new RegisterStudentOperation();
            rso.print("I'll gradute soon!");
        }

        public static string HighestSalaryEmployee(List<Employee> empList)
        {
            decimal highestSalary = 0;
            Employee highestSalaryEmp = new Employee();
            foreach (Employee emp in empList)
            {
                if (emp.salary > highestSalary)
                {
                    highestSalary = emp.salary;
                    highestSalaryEmp = emp;
                }
            }
            return highestSalaryEmp.name;
        }
        public static string LowestSalaryEmployee(List<Employee> empList)
        {
            decimal lowestSalary = empList[0].salary;
            Employee lowestSalaryEmp = new Employee();
            foreach (Employee emp in empList)
            {
                if (emp.salary < lowestSalary)
                {
                    lowestSalary = emp.salary;
                    lowestSalaryEmp = emp;
                }
            }
            return lowestSalaryEmp.name;
        }
        static bool IsHasVowel(string str)
        {
            string vowel = "";
            if(str.ToUpper().Contains("A"))
                vowel= "A";
            if (str.ToUpper().Contains("E"))
                vowel += "E";
            if (str.ToUpper().Contains("I"))
                vowel += "I";
            if (str.ToUpper().Contains("O"))
                vowel += "O";
            if (str.ToUpper().Contains("U"))
                vowel += "U";
            if(vowel != "")
            {
                Console.WriteLine("{0} contains {1}", str, vowel);
                return true;
            }
            return false;
        }
    }
}
