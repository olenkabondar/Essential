using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Task
{
    internal class Body : DocumentPart
    {
        protected override ConsoleColor GetColor() 
        { 
            return ConsoleColor.Red; 
        }
    }
}
