using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Student
    {

        public delegate void Print(string message);
        public event Print printEvent;
        public void PrintMessage(string message)
        {
            if (printEvent != null)
                printEvent.Invoke(message);
        }

    }
}
