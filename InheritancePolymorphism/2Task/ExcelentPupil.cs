using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Task
{
    internal class ExcellentPupil : Pupil
    {
        public override void Study() { Console.WriteLine("Pupil is study excelent."); }
        public override void Read() { Console.WriteLine("Pupil is read excelent."); }
        public override void Write() { Console.WriteLine("Pupil is write excelent."); }
        public override void Relax() { Console.WriteLine("Pupil is relax excelent."); }
    }
}
