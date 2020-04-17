using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class MyGenericClass<T> where T : class
    {
        private T genericMemberVariable;

        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T genericProperty { get; set; }
    }
}
