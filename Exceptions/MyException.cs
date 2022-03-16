using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// NOTE: M-am inspirat putin(mai mult) de pe net la partea asta cu custom exception pt ca nu am prea inteles-o :)

namespace Exceptions
{
    public class MyException : Exception
    {
        public MyException()
        {

        }
        public MyException(string name) : base(String.Format($"{name} is not a proper name!"))
        {

        }
        public MyException(int age) : base(String.Format($"{age} is not a proper age!"))
        {

        }
    }
}
