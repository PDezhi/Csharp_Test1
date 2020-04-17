using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Employee
    {
        public int id;
        public string name;
        public decimal salary;
        public string officeAddress;
        public Employee(int id, string name, decimal salary,string officeAddress)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.officeAddress = officeAddress;
        }
        public Employee()
        {

        }
    }
}
