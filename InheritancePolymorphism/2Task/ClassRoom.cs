using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Task
{
    internal class ClassRoom
    {
        private Pupil[] pupils = new Pupil[4];
        public ClassRoom(Pupil[] inputPupils)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i < inputPupils.Length)
                    pupils[i] = inputPupils[i];
                else
                    pupils[i] = new Pupil(); //якщо передано менше 4, створюємо звичайного учня
            }
        }
        public void ShowPupilAbilities()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($" Учень №{i + 1}");
                Console.ResetColor();
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
            }
        }

    }
}
