using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Task
{
    internal class GoodPupil: Pupil
    {
        public override void Study() { Console.WriteLine("Pupil is study good."); }
        public override void Read() { Console.WriteLine("Pupil is read good."); }
        public override void Write() { Console.WriteLine("Pupil is write good."); }
        public override void Relax() { Console.WriteLine("Pupil is relax good."); }
    }
}
