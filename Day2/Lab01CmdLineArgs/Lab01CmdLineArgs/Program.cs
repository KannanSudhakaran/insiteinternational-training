



using System;
using System.Reflection;

class Program {


    static void Main(string[] studentNames) {
         
        Console.WriteLine("Inside main");
        Console.WriteLine(studentNames.Length);
        if (studentNames.Length == 0)
        {
            Console.WriteLine("Hey why dont you pass some names as arguments");
        }
        else {
            //HardCoding is not clean code
            //Console.WriteLine("hello "+ studentNames[0]);
            //Console.WriteLine("hello " + studentNames[1]);
            //Console.WriteLine("hello " + studentNames[2]);
            //Console.WriteLine("hello " + studentNames[3]);

            //ctrl+r + r ==> refactor and renaming
            //for (int index = 0; index < studentNames.Length; index++) {

            //    Console.WriteLine("hello " + studentNames[index]);
            //}

            //for (int index = 1; index <= studentNames.Length; index++)
            //{
            //    Console.WriteLine("hello " + studentNames[studentNames.Length - index]);
            //}

            //clean code
            foreach (string item in studentNames) {

                Console.WriteLine("hello " + item);
            }

        }
    
    }


}