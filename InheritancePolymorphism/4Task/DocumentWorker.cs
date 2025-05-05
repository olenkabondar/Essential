using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Task
{
    internal class DocumentWorker
    {
        public virtual void OpenDocument() { Console.WriteLine("Документ відкритий."); }
        public virtual void EditDocument() { Console.WriteLine("Редагування документа у версії Про."); }
        public virtual void SaveDocument() { Console.WriteLine("Збереження документа у версії Про."); }
    }
}
