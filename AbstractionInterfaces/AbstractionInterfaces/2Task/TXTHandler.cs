using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Task
{
    internal class TXTHandler: AbstractHandler
    {
        public TXTHandler()
        {
            Open();
            Create();
            Change();
            Save();
        }
        public override void Open() { Console.WriteLine("Open document in TXT file."); }
        public override void Create() { Console.WriteLine("Create document in TXT file."); }
        public override void Change() { Console.WriteLine("Change document in TXT file."); }
        public override void Save() { Console.WriteLine("Save document in TXT file."); }
    }
}
