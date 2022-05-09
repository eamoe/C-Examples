//directive. Says to the compiler that the program uses the System namespace.
//Namespace is a grouping of related code elements: classes, structures, enums, etc.
//We can declare a namespace ourselves. It prevents naming conflicts.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    //A Simple Program to display the words Hello World

    class Program
    {
        static void Main(string[] args)
        {
            int x = (int) 20.5;
            Console.WriteLine(x);
        }
    }
}