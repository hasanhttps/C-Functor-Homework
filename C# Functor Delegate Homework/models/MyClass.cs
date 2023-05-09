using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funct.models {
    public class MyClass {

        public void Space(string str) {
            char myChar = '_';
            Console.WriteLine(string.Concat(str.Select(c => c.ToString() + myChar.ToString())));
        }
        public void Reverse(string str) {
            Console.WriteLine(str.Reverse().ToArray()); 
        }
    }
}
