using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestExercise
{
    class Age
    {
        public void AgeCheck(int age)
        {
            while (true)
            {
                if (age < 18)
                {
                    Console.WriteLine("Sorry, you are disqualified for this test.");
                    //continue;
                    Console.ReadLine();
                }

                else if (age > 18 && age < 40)
                {
                    Console.WriteLine("Welcome, get ready for your test (Press enter!)");
                    Console.ReadLine();
                    break;
                }

                else
                {
                    Console.WriteLine("Sorry, you are unable to continue now. Please standby for the coming exercise");
                    Console.ReadLine();
                }
                // age--; 
            }
            



            Console.WriteLine("Please select E for English or M for Mathematics");
            char exerciseLetter = Convert.ToChar(Console.ReadLine());

            var selecto = new OptionSelect();
            
            selecto.selectOption(exerciseLetter);
        }
    }
}
