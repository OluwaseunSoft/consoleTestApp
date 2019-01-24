using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestExercise
{
    class OptionSelect
    {
        public void selectOption(char em)
        {
            char E = 'E';
            char M = 'M';

            if (em == E)
            {
                var EnglishExe = new English();
                EnglishExe.Englishi();
            }

            else if (em == M)
            {
                var MathsExe = new Maths();
                MathsExe.Mathsi();
            }

            else
            {
                Console.WriteLine("Type the letter for your prefered exercise E for English, M for Mathematics, and try again");
            }
        }
    }
}
