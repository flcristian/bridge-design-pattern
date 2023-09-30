using bridge_design_pattern.abstraction;
using bridge_design_pattern.implementor;

internal class Program
{
    private static void Main(string[] args)
    {
        Abstraction abstraction = new RefinedAbstraction();
        abstraction.Implementer = new ImplementationA();
        abstraction.Operation();

        Console.WriteLine();

        abstraction.Implementer = new ImplementationB();
        abstraction.Operation();
    }
}