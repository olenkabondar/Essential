using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Task
{
    internal class Pupil
    {
        public virtual void Study() { Console.WriteLine("Pupil can study."); }
        public virtual void Read() { Console.WriteLine("Pupil can read."); }
        public virtual void Write() { Console.WriteLine("Pupil can write."); }
        public virtual void Relax() { Console.WriteLine("Pupil can relax."); }
    }
}
