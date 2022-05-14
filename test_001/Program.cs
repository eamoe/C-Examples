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
            //Casting
            //int x = (int) 20.5;

            // Arrays
            //int[] userAge = {21, 22, 23, 24, 25};
            int [] userAge = new int[5];
            userAge = new [] {21, 22, 23, 24, 25};

            //Methods
            int [] source = {12, 1, 5, -2, 16, 14};
            int [] dest = {1, 2, 3, 4};
            
            Array.Copy(source, dest, 3);

            //Console.WriteLine(Array.IndexOf(source, 25));

            for (int i = 0; i < source.Length; i++)
            {
                //Console.WriteLine(source[i]);
            }

            //Strings
            string message = "Hello World";
            string anotherMessage = "";

            //concatenation 
            string myName = "Hello World, " + "my name is Eugene";

            //substring
            string newMessage = message.Substring(2, 5);

            //equals
            string firstString = "This is Eugene";
            string secondString = "Hello";
            //Console.WriteLine(firstString.Equals("This is Eugene"));
            //Console.WriteLine(firstString.Equals(secondString));

            //split
            //Suppose you want to split the string "Peter, John; Andy, , David" into substrings
            string [] separator = {", ", "; "};
            string names = "Peter, John; Andy, , David";
            string [] substrings = names.Split(separator, StringSplitOptions.None);

            for (int i = 0; i < substrings.Length; i++)
            {
                //Console.WriteLine(substrings[i]);
            }

            //Lists
            List<int> userAgeList = new List<int>();

            List<int> newUserAgeList = new List<int> {11, 21, 31, 41};
            
            newUserAgeList.Add(100);

            for(int i = 0; i < newUserAgeList.Count; i++)
            {
                Console.Write($"{newUserAgeList[i]} ");
            }
        }
    }
}