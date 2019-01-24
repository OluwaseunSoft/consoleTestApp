using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Sharp-Brains Automated Aptitude Test System\n Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            var ageCase = new Age();
            ageCase.AgeCheck(age);          

        }
    }
}
