using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassImplementation
{
    public class ClassType3 : ClassBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Question { get; set; }

        public override void ToStringMy()
        {
            Console.WriteLine("Class1" + Name + Description + Question);
        }
    }
}
