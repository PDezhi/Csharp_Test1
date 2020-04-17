using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class RegisterStudentOperation
    {
        private Student stu;
        public RegisterStudentOperation()
        {
            stu = new Student();
            stu.printEvent += PrintMessage;
        }
        public void print(string message)
        {
            stu.PrintMessage(message);
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
