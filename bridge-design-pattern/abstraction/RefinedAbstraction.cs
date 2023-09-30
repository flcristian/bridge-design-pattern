using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_design_pattern.abstraction
{
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            Console.WriteLine("RefinedAbstraction:Operation()");
            Implementer!.OperationImplementation();
        }
    }
}
