using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public static class MyExtentionClass
    {

            public static bool IsDividableBy3(this int i)
            {
                return i %3 == 0;
            }
    
    }
}
