using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Task
{
    abstract class DocumentPart
    {
        protected string content;

        public virtual string Content{ get;set; }


        public virtual void Show()
        {
            Console.ForegroundColor = GetColor();
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.White;
        }

        protected abstract ConsoleColor GetColor();
    }
}
