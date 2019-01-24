using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestExercise
{
    class English
    {
        public void Englishi()
        {
            int correctAns = 0;
            int wrongAns = 0;

            char u = 'u';
            char s = 's';
            char w = 'w';
            char m = 'm';
            char n = 'n';


            string que1 = "Fill in the gap \n 1. comp_ter";
            Console.WriteLine(que1);
            char ques1Ans = Convert.ToChar(Console.ReadLine());
            if (ques1Ans == u)
            {
                ++correctAns;
            }
            else
            {
                ++wrongAns;
            }

            string que2 = @"2. joy_tick ";
            Console.WriteLine(que2);
            char ques2Ans = Convert.ToChar(Console.ReadLine());
            if (ques2Ans == s)
            {
                ++correctAns;
            }
            else
            {
                ++wrongAns;
            }


            string que3 = @"3. _icrosoft ";
            Console.WriteLine(que3);
            char ques3Ans = Convert.ToChar(Console.ReadLine());
            if (ques3Ans == m)
            {
                ++correctAns;
            }
            else
            {
                ++wrongAns;
            }



            string que4 = @"4. net_ork ";
            Console.WriteLine(que4);
            char ques4Ans = Convert.ToChar(Console.ReadLine());
            if (ques4Ans == w)
            {
                ++correctAns;
            }
            else
            {
                ++wrongAns;
            }



            string que5 = @"5. inter_et ";
            Console.WriteLine(que5);
            char ques5Ans = Convert.ToChar(Console.ReadLine());
            if (ques5Ans == n)
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
