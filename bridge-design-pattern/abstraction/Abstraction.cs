using bridge_design_pattern.implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_design_pattern.abstraction
{
    public abstract class Abstraction
    {
        public Bridge? Implementer { get; set; }

        public virtual void Operation()
        {
            Console.WriteLine("ImplementationBase:Operation()");
            Implementer!.OperationImplementation();
        }
    }
}
