using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestExercise
{
    class Maths
    {
        public void Mathsi()
        {
            int correctAns = 0;
            int wrongAns = 0;

            string que1 = @"1. 3 x 8 = ";
            Console.WriteLine(que1);
            var ques1Ans = Convert.ToInt32(Console.ReadLine());
            if (ques1Ans == 24)
            {
                ++correctAns;
            }
            else
            {
                ++wrongAns;
            }

            string que2 = @"2. 5 + 8 = ";
            Console.WriteLine(que2);
            var ques2Ans = Convert.ToInt32(Console.ReadLine());
            if (ques2Ans == 13)
            {
                ++correctAns;
            }
            else
            {
                ++wrongAns;
            }


            string que3 = @"3. 5 - 2 = ";
            Console.WriteLine(que3);
            var ques3Ans = Convert.ToInt32(Console.ReadLine());
            if (ques3Ans == 3)
            {
                ++correctAns;
            }
            else
            {
                ++wrongAns;
            }



            string que4 = @"4. 6 \ 2 = ";
            Console.WriteLine(que4);
            var ques4Ans = Convert.ToInt32(Console.ReadLine());
            if (ques4Ans == 3)
            {
                ++correctAns;
            }
            else
            {
                ++wrongAns;
            }



            string que5 = @"5. 5 + 12 = ";
            Console.WriteLine(que5);
            var ques5Ans = Convert.ToInt32(Console.ReadLine());
            if (ques5Ans == 17)
            {
                ++correctAns;
            }
            else
            {
                ++wrongAns;
            }

            Console.WriteLine("Thank you for your time taking this exercise \n Wrong Answers: {0} , Correct Answers: {1}", wrongAns, correctAns);
        }
    }
}
