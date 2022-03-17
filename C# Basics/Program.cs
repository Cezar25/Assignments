using System;
using System.Collections;

namespace assign3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var university = University.GetDefaultUniversity();
            Menu.Start(university);
        }    
}
}