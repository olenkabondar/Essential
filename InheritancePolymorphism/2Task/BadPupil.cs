using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Task
{
    internal class BadPupil: Pupil
    {
        public override void Study() { Console.WriteLine("Pupil is study bad."); }
        public override void Read() { Console.WriteLine("Pupil is read bad."); }
        public override void Write() { Console.WriteLine("Pupil is write bad."); }
        public override void Relax() { Console.WriteLine("Pupil is relax bad."); }
    }
}
