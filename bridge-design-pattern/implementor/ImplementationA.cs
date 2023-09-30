using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_design_pattern.implementor
{
    public class ImplementationA : Bridge
    {
        public void OperationImplementation()
        {
            Console.WriteLine("ImplementationA:OperationImplementation()");
        }
    }
}
