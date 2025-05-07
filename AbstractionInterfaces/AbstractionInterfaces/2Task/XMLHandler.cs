using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Task
{
    internal class XMLHandler: AbstractHandler
    {
        public XMLHandler()
        {
            Open();
            Create();
            Change();
            Save();
        }
        public override void Open() { Console.WriteLine("Open document in XML file."); }
        public override void Create() { Console.WriteLine("Create document in XML file."); }
        public override void Change() { Console.WriteLine("Change document in XML file."); }
        public override void Save() { Console.WriteLine("Save document in XML file."); }
    }
}
